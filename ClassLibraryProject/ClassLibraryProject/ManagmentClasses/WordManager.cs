using Microsoft.Office.Interop.Word;
using System;

namespace ClassLibraryProject.ManagmentClasses
{
   public class WordManager
    {
        public void ContractDoc(string employeeID)
        {

            try
            {
                //Create an instance for word app  
              Application winword = new Application();

                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = true;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document  
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                    headerRange.Font.Size = 25;
                    headerRange.Text = "Media bazaar contract";
                }

                ////Add the footers into the document  
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 20;
                    footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                    footerRange.Text = "____________________" + Environment.NewLine;
                }

                //adding text to document  
                document.Content.SetRange(100,100);
                document.Content.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                document.Content.Text = "This is test document " + Environment.NewLine;

                //Add paragraph with Heading 1 style
                Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                para1.Range.Text = "";
                para1.Range.InsertParagraphAfter();

                ////Add paragraph with Heading 2 style  
                Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                para1.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                para2.Range.Text = "Para 2 text";
                para2.Range.InsertParagraphAfter();

                ////Create a 5X5 table and insert some dummy record  
                //Table firstTable = document.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

                //firstTable.Borders.Enable = 1;
                //foreach (Row row in firstTable.Rows)
                //{
                //    foreach (Cell cell in row.Cells)
                //    {
                //        //Header row  
                //        if (cell.RowIndex == 1)
                //        {
                //            cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                //            cell.Range.Font.Bold = 1;
                //            //other format properties goes here  
                //            cell.Range.Font.Name = "verdana";
                //            cell.Range.Font.Size = 10;
                //            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                //            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                //            //Center alignment for the Header cells  
                //            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                //        }
                //        //Data row  
                //        else
                //        {
                //            cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                //        }
                //    }
                //}

                //Save the document  
                Object oSaveAsFileWord = @"D:\Company\Contracts\" + employeeID + "  " + DateTime.Now.ToString("yyyy-MM-dd HH-MM") + ".doc";

                document.SaveAs(
                                 ref oSaveAsFileWord, ref missing, ref missing, ref missing,
                                 ref missing, ref missing, ref missing, ref missing,
                                 ref missing, ref missing, ref missing, ref missing,
                                 ref missing, ref missing, ref missing, ref missing);

                //document.Close(ref missing, ref missing, ref missing);
                //document = null;
                //winword.Quit(ref missing, ref missing, ref missing);
                //winword = null;
            }
            catch (Exception ex)
            {
            }

        }
    }
}
