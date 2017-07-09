using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ByteVieer
{
    internal class ByteWriter
    {
        public struct RichTextboxes
        {
            public RichTextBox dataTextbox;
            public RichTextBox lineTextbox;
            public RichTextBox asciiTextBox;
            public RichTextBox columnTextbox;
        }

        private byte[] _data;

        private readonly List<string> _rowLabels = new List<string>();

        private readonly StringBuilder _dataSb = new StringBuilder();
        private readonly StringBuilder _asciiSb = new StringBuilder();
        private readonly StringBuilder _lineSb = new StringBuilder();
        private readonly StringBuilder _columnSb = new StringBuilder();

        private short _colCount;
        private short _colWidth;
        private bool _colSpacing;
        private short _base;
        private short _paddingRequired;
        private ByteViewer.DisplayFormat _format;

        private int CountPerColumn => _colCount * _colWidth;

        private ByteWriter()
        {

        }

        private void Build()
        {
            int row = 0;
            int bIdx = 0;

            int numberOfBytes = _data.Length;
            int rowPadding = (int)Math.Ceiling(Math.Log10(numberOfBytes));
            int noOfBytesPerLine = _colWidth * _colCount;


            for (int col = 0; col < noOfBytesPerLine; ++col)
            {
                string converted = Convert.ToString(col, _base).ToUpper();
                string padded = converted.PadLeft(_paddingRequired, '0');

                _columnSb.Append(padded);


                if (_colSpacing && (col + 1) > 0 && ((col + 1) % _colWidth == 0))
                {
                    _columnSb.Append("  ");
                }
                else if (col < (noOfBytesPerLine - 1))
                {
                    _columnSb.Append(" ");
                }
            }

            while (bIdx < _data.Length)
            {
                AddRow(row, rowPadding);
                int col;

                for (col = 0; col < _colCount; ++col)
                {
                    int count = Math.Min(_colWidth, _data.Length - bIdx);

                    ArraySegment<byte> segment = new ArraySegment<byte>(_data, bIdx, count);
                    AddByteSegment(segment);

                    bIdx += count;

                    if (_colSpacing)
                    {
                        AddColumnSpace();
                    }
                }

                ++row;
            }
        }

        private void AddByteSegment(ArraySegment<byte> segment)
        {

            int total = (segment.Offset + segment.Count);
            for (int i = segment.Offset; i < total; ++i)
            {
                byte val = segment.Array[i];

                string converted = Convert.ToString(val, _base).ToUpper();
                string padded = converted.PadLeft(_paddingRequired, '0');
                _dataSb.Append(padded);

                if (i < (total - 1))
                {
                    _dataSb.Append(" ");
                }

                if (val > 31)
                {
                    _asciiSb.Append((char)val);
                }
                else
                {
                    _asciiSb.Append('.');
                }
            }
        }

        private void AddColumnSpace()
        {
            _dataSb.Append("  ");
            _asciiSb.Append("  ");
        }

        private void AddRow(int row, int rowPadding)
        {
            if (row > 0)
            {
                _dataSb.Append("\r\n");
                _asciiSb.Append("\r\n");
            }

            int actualPos = row * CountPerColumn;

            string converted = Convert.ToString(actualPos, _base).ToUpper();
            string padded = converted.PadLeft(rowPadding, '0');

            _lineSb.Append(padded).Append("\r\n");
        }

        public void Write(byte[] data, RichTextboxes target)
        {
#if DEBUG
            if (null == data) throw new ArgumentNullException(nameof(data));
#endif
            _data = data;

            _dataSb.Clear();
            _asciiSb.Clear();
            _lineSb.Clear();

            target.dataTextbox.Text = string.Empty;
            Build();
            target.dataTextbox.Text = _dataSb.ToString();
            target.lineTextbox.Text = _lineSb.ToString();
            target.asciiTextBox.Text = _asciiSb.ToString();
            target.columnTextbox.Text = _columnSb.ToString();
        }

        public class Builder
        {
            private readonly ByteWriter _writer = new ByteWriter();

            public Builder()
            { }

            public Builder SetColumnCount(short colCount)
            {
                _writer._colCount = colCount;
                return this;
            }

            public Builder SetColSpacing(bool spacing)
            {
                _writer._colSpacing = spacing;
                return this;
            }

            public Builder SetDisplayFormat(ByteViewer.DisplayFormat format)
            {
                _writer._format = format;
                return this;
            }

            public Builder SetColWidth(short width)
            {
                _writer._colWidth = width;
                return this;
            }

            public ByteWriter Build()
            {
                if (_writer._colWidth < 1) throw new ArgumentException("The column width must be bigger than 0");
                if (_writer._colCount < 1) throw new ArgumentException("The column count must be bigger than 0");

                _writer._base = (short)_writer._format;
                _writer._paddingRequired = (short)Math.Ceiling(Math.Log(255, _writer._base));

                return _writer;
            }
        }

    }
}