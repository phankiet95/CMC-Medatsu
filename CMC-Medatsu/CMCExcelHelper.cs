using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace CMC_Medatsu
{
    class CMCExcelHelper
    {
        private XLWorkbook workbook;

        private const string goukaku = "合格";
        private const string shippai = "失敗";
        private const string ketatsu = "桁数";
        private const string OK = "OK";
        private const string NG = "NG";
        private const string type2Trait = "チェック条件／確認内容";

        private const int undefinedType = 0;
        private const int type1 = 1;
        private const int type2 = 2;

        private List<Tuple<string, string, string, string, string, string>> formulaTupple = new List<Tuple<string, string, string, string, string, string>>();

        public CMCExcelHelper(String path)
        {
            workbook = new XLWorkbook(path);
        }

        public List<string> getListWorkSheetName()
        {
            List<string> listWS = new List<string>();
            foreach (IXLWorksheet worksheet in workbook.Worksheets)
            {
                listWS.Add(worksheet.Name);
            }
            return listWS;
        }

        public XLWorkbook startIndexing(int startIndex, string functionName, int numberDigit, string date, string pic)
        {

            foreach (IXLWorksheet worksheet in workbook.Worksheets)
            {
                startIndex = fillIndex(worksheet, startIndex, functionName, numberDigit, date, pic);
            }

            int currentRow = 9;
            IXLWorksheet ResultWS = workbook.Worksheet("テスト結果概要");
            foreach (Tuple<string,string,string,string,string,string> tup in formulaTupple)
            {
                ResultWS.Cell(currentRow, "B").Value = tup.Item1;
                ResultWS.Cell(currentRow, "C").FormulaA1 = tup.Item2;
                ResultWS.Cell(currentRow, "D").FormulaA1 = tup.Item3;
                ResultWS.Cell(currentRow, "E").FormulaA1 = tup.Item4;
                ResultWS.Cell(currentRow, "F").FormulaA1 = tup.Item5;
                ResultWS.Cell(currentRow, "G").FormulaA1 = tup.Item6;
                currentRow++;
            }
            ResultWS.Rows().AdjustToContents();

            return workbook;

        }

        private int fillIndex(IXLWorksheet worksheet, int startIndex, string functionName, int numberDigit, string date, string pic)
        {
            int type = checkSheetType(worksheet);
            string indexString = "";
            if (type == type1)
            {
                int currentRow = 13;
                int lastRow = worksheet.LastRowUsed().RowNumber();
                while (currentRow <= lastRow)
                {
                    indexString = functionName + MedatsuStringHelper.getNext(startIndex, numberDigit);
                    worksheet.Cell(currentRow, "A").Value = indexString;
                    currentRow++;
                    startIndex++;
                }

                // Update formular
                string range = "F13:F";
                if (ketatsu.Equals(worksheet.Cell(12, "F").Value))
                {
                    range = "G13:G";
                }

                worksheet.Cell(10, "A").FormulaA1 = "=COUNTIF(" + range + lastRow + ",\"合格\")";
                worksheet.Cell(10, "B").FormulaA1 = "=COUNTIF(" + range + lastRow + ",\"失敗\")";
                worksheet.Cell(10, "D").FormulaA1 = "=COUNTIF(" + range + lastRow + ",\"N/A\")";
                worksheet.Cell(10, "E").FormulaA1 = "=COUNTA(A13:A" + lastRow + ")";

                // Tester
                worksheet.Cell(8, "B").Value = pic;

                // test Result sheet
                string sheetName = "'" + worksheet.Name + "'";
                Tuple<string, string, string, string, string, string> tup = new Tuple<string, string, string, string, string, string>(
                        worksheet.Name,
                        sheetName + "!E10",
                        sheetName + "!A10",
                        sheetName + "!B10",
                        sheetName + "!D10",
                        sheetName + "!C10"
                        );
                formulaTupple.Add(tup);
            }

            if (type == type2)
            {
                int currentCol = 3;
                int lastCol = worksheet.LastColumnUsed().ColumnNumber();
                int lastRow = worksheet.LastRowUsed().RowNumber();
                while (currentCol <= lastCol)
                {
                    indexString = functionName + MedatsuStringHelper.getNext(startIndex, numberDigit);
                    worksheet.Cell(9 , currentCol).Value = indexString;
                    // Update pic && date
                    worksheet.Cell(lastRow, currentCol).Value = pic;
                    worksheet.Cell(lastRow - 1, currentCol).Value = date;
                    currentCol++;
                    startIndex++;
                }

                string colLetter = MedatsuStringHelper.getExcelColumnName(lastCol);
                int resultCol = lastRow - 2;

                int resultSheetRow = 9 + formulaTupple.Count;
                string sheetName = "'" + worksheet.Name + "'";

                // test Result sheet
                Tuple<string, string, string, string, string, string> tup = new Tuple<string, string, string, string, string, string>(
                        worksheet.Name,
                        "=COUNTA(" + sheetName + "!C9:"+ colLetter + "9)",
                        "=COUNTIF(" + sheetName + "!C" + resultCol + ":" + colLetter + resultCol + ",\"OK\")",
                        "=COUNTIF(" + sheetName + "!C" + resultCol + ":" + colLetter + resultCol + ",\"不良\")",
                        "=COUNTIF(" + sheetName + "!C" + resultCol + ":" + colLetter + resultCol + ",\"‐\")",
                        "=C"+ resultSheetRow + "-D"+ resultSheetRow + "-E"+ resultSheetRow + "-F"+ resultSheetRow
                        );
                formulaTupple.Add(tup);
            }

            return startIndex;
            
        }

        private int checkSheetType(IXLWorksheet worksheet)
        {
            if (goukaku.Equals(worksheet.Cell(9, "A").Value) && shippai.Equals(worksheet.Cell(9, "B").Value)) {
                return type1;
            }

            if (type2Trait.Equals(worksheet.Cell(9, "A").Value) || type2Trait.Equals(worksheet.Cell(8, "A").Value)) {
                return type2;
            }

            return undefinedType;
        }
    }
}
