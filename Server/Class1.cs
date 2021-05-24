﻿using System;

public class DocumetGeneration
{
	public DocumetGeneration()
	{
            
            DocX doc = DocX.Create("Cod.docx");
            doc.InsertParagraph("Транспортное республиканское унитарное предприятие").
                Font("Times New Roman").
                FontSize(11).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[0].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 2);

            doc.InsertParagraph("\t\"БАРАНОВИЧСКОЕ ОТДЕЛЕНИЕ").
                Font("Times New Roman").
                FontSize(10).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.InsertParagraph("            БЕЛОРУССКОЙ ЖЕЛЕНЗНОЙ ДОРОГИ\"").
                Font("Times New Roman").
                FontSize(10).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.InsertParagraph("          ВОЛКОВЫССКАЯ ДИСТАНЦИЯ ПУТИ").
                Font("Times New Roman").
                FontSize(10).
                Bold().
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.InsertParagraph("             ___________________№______________").
                Font("Times New Roman").
                FontSize(11).
                Bold().
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[4].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 20);

            doc.InsertParagraph("КОМАНДИРОВОЧНОЕ УДОСТОВЕРЕНИЕ №322").
                Font("Times New Roman").
                FontSize(13).
                Bold().
                Alignment = Xceed.Document.NET.Alignment.center;

            doc.Paragraphs[5].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 25);

            //НУЖЕН КУРСИВ

            doc.InsertParagraph("Выдано                          ______Кухта Алексей Владимирович________________").
                Font("Times New Roman").
                FontSize(11).
                Bold().
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[6].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 0);

            doc.InsertParagraph("                                                                              (фамилия, имя, отчество)").
                Font("Times New Roman").
                FontSize(10).
                //AppendLine(text.Trim()).
        Alignment = Xceed.Document.NET.Alignment.left;

            doc.InsertParagraph("Инженер-программист_________________________________________________").
                Font("Times New Roman").
                FontSize(11).
                Bold().
                UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[8].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 0);

            doc.InsertParagraph("                      (наименование организации, выдавшей удостоверение)").
                Font("Times New Roman").
                FontSize(10).
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[9].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 3);

            doc.InsertParagraph("командированному в г.Барановичи, БарГУ").
                Font("Times New Roman").
                FontSize(11).
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[10].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 0);

            doc.InsertParagraph("Срок командировки: сроком на 228 дней с 06.05.2020г по 22.12.2020г").
                Font("Times New Roman").
                FontSize(11).
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[11].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 5);

            doc.InsertParagraph("Для участия в курсах переподготовки в профессии «Инженер-программист»").
                Font("Times New Roman").
                FontSize(11).
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[11].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 10);

            doc.InsertParagraph("_____________________________________________________________________").
                Font("Times New Roman").
                FontSize(11).
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[12].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 10);

            doc.InsertParagraph("Основание: приказ №322 ЛС от 19.07.2019г").
                Font("Times New Roman").
                FontSize(11).
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[13].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 10);

            doc.InsertParagraph("  Действительно по предъявлении паспорта, удострверения личности.").
                Font("Times New Roman").
                FontSize(11).
                //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
                Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[14].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 15);

            doc.InsertParagraph("Начальник дистанции пути                                             В.В.Зеленский").
              Font("Times New Roman").
              FontSize(12).
              UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
              Alignment = Xceed.Document.NET.Alignment.left;

            doc.Paragraphs[15].SetLineSpacing(Xceed.Document.NET.LineSpacingType.After, 10);

            doc.InsertParagraph("                                М.П.").
              Font("Times New Roman").
              FontSize(8).
              //UnderlineStyle(Xceed.Document.NET.UnderlineStyle.singleLine).
              Alignment = Xceed.Document.NET.Alignment.left;


            doc.Save();
}
