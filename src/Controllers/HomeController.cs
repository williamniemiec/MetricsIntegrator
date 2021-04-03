﻿using Avalonia.Controls;
using MetricsIntegrator.Integrator;
using MetricsIntegrator.IO;
using MetricsIntegrator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using Image = Avalonia.Controls.Image;

namespace MetricsIntegrator.Controllers
{
    public class HomeController
    {
        //---------------------------------------------------------------------
        //		Attributes
        //---------------------------------------------------------------------
        private MainWindow window;
        private string inFileChoose;


        //---------------------------------------------------------------------
        //		Constructors
        //---------------------------------------------------------------------
        public HomeController(MainWindow window)
        {
            this.window = window;
        }


        //---------------------------------------------------------------------
        //		Methods
        //---------------------------------------------------------------------
        public Task<string> AskUserForMappingFile()
        {
            return AskUserForCSVFileOfType("Mapping file");
        }

        private async Task<string> AskUserForCSVFileOfType(string type)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filters.Add(new FileDialogFilter() { Name = type, Extensions = { "csv" } });
            dialog.AllowMultiple = false;

            string[] result = await dialog.ShowAsync(window);

            return ((result != null) && (result.Length > 0))
                    ? result[0]
                    : "";
        }

        public Task<string> AskUserForMetricsFile()
        {
            return AskUserForCSVFileOfType("Metrics file");
        }

        public void OnIntegrate(string projectName, string mapPath, 
                                string sourceCodePath, string testCasePath, 
                                string testPathsPath)
        {
            MetricsIntegrationManager integrator = new MetricsIntegrationManager(
                projectName,
                CreateMetricsFileManager(mapPath, sourceCodePath, testCasePath, testPathsPath)
            );

            window.NavigateToExportView(integrator);
        }

        private MetricsFileManager CreateMetricsFileManager(string mapPath,
                                                            string sourceCodePath, 
                                                            string testCasePath,
                                                            string testPathsPath)
        {
            MetricsFileManager metricsFileManager = new MetricsFileManager();

            metricsFileManager.MapPath = mapPath;
            metricsFileManager.SourceCodePath = sourceCodePath;
            metricsFileManager.TestCasePath = testCasePath;
            metricsFileManager.TestPathsPath = testPathsPath;

            return metricsFileManager;
        }
    }
}
