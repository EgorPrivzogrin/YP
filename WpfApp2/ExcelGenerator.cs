using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using System;
using System.Linq;

namespace WpfApp2
{
    internal class ExcelGenerator
    {
        public byte[] Generate(Hrreport report)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();

            var sheet = package.Workbook.Worksheets
            .Add("Hrreport");

            sheet.Cells["C1"].Value = "Работники";

            sheet.Cells["A2"].Value = "Имя";
            report.Employments.ForEach(employment =>
            {
                sheet.Cells[report.Employments.FindIndex(e => employment.EploymentId == e.EploymentId) + 3, 1].Value = employment.Name;
                return;
            });

            sheet.Cells["B2"].Value = "Фамилия";
            report.Employments.ForEach(employment =>
            {
                sheet.Cells[report.Employments.FindIndex(e => employment.EploymentId == e.EploymentId) + 3, 2].Value = employment.Surname;
                return;
            });

            sheet.Cells["C2"].Value = "Отчество";
            report.Employments.ForEach(employment =>
            {
                sheet.Cells[report.Employments.FindIndex(e => employment.EploymentId == e.EploymentId) + 3, 3].Value = employment.Patronymic;
                return;
            });

            sheet.Cells["D2"].Value = "Дата рождения";
            report.Employments.ForEach(employment =>
            {
                sheet.Cells[report.Employments.FindIndex(e => employment.EploymentId == e.EploymentId) + 3, 4].Value = employment.DateOfBirth;
                return;
            });

            sheet.Cells["E2"].Value = "Номер телефона";
            report.Employments.ForEach(employment =>
            {
                sheet.Cells[report.Employments.FindIndex(e => employment.EploymentId == e.EploymentId) + 3, 5].Value = Int64.Parse(employment.ContactNumber);
                return;
            });

            sheet.Cells["F2"].Value = "Название отдела";
            report.Employments.ForEach(employment =>
            {
                sheet.Cells[report.Employments.FindIndex(e => employment.EploymentId == e.EploymentId) + 3, 6].Value = employment.Department;
                return;
            });

            sheet.Column(4).Style.Numberformat.Format = "yyyy-mm-dd";
            sheet.Cells.AutoFitColumns();
            return package.GetAsByteArray();
        }

    }
}
