﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DaysPravoslavie;
using HtmlAgilityPack;
using Day = DaysPravoslavie.Day;

namespace Scheduler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var days = Helper.GetDays(2018, 10);

            var d = new Day(days[0].Date, Helper.GetHtmlDocument(days[0].HtmlPath));

            var doc = Helper.CreateDocument(new List<DaysPravoslavie.Day>());

            //foreach(var ds in days)
            //{
            //    var doc = Helper.GetHtmlDocument(ds.HtmlPath);
            //    DaysPravoslavie.Day day = new DaysPravoslavie.Day(ds.Date, doc);

            //}

            return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}