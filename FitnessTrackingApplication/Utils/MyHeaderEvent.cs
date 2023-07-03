using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Font = iTextSharp.text.Font;

namespace FitnessTrackingApplication.Utils
{
    public class MyHeaderEvent : PdfPageEventHelper
    {
        //Define the font and text for the header
        iTextSharp.text.Font FONT = new iTextSharp.text.Font(Font.FontFamily.HELVETICA, 18, Font.BOLD);
        string HEADER_TEXT = "";

        public MyHeaderEvent(string HEADER_TEXT)
        {
            this.HEADER_TEXT = HEADER_TEXT;
        }

        //Override the OnEndPage method
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            //Get the canvas object
            PdfContentByte canvas = writer.DirectContent;
            //Show the header text on the left side of the page
            ColumnText.ShowTextAligned(
              canvas, Element.ALIGN_CENTER,
              new Phrase(HEADER_TEXT, FONT),
              10, 810, 0
            );
        }
    }
}
