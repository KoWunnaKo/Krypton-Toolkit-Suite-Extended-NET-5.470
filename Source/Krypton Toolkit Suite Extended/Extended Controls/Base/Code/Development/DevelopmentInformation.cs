﻿using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Enumerations;
using GlobalUtilities.Classes;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace ExtendedControls.Base.Code.Development
{
    public class DevelopmentInformation
    {
        #region Variables
        private Version _internalVersion = Assembly.GetExecutingAssembly().GetName().Version, _assemblyVersion;
        private FileInfo _fileInfo;
        #endregion

        #region Properties
        public Version AssemblyVersion { get => _assemblyVersion; set => _assemblyVersion = value; }

        public Version InternalVersion { get => _internalVersion; }
        #endregion

        #region Constructors
        public DevelopmentInformation()
        {

        }
        #endregion

        #region Methods                
        /// <summary>
        /// Sets the build information.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="state">The state.</param>
        public static void SetBuildInformation(KryptonForm target, DevelopmentStates state = DevelopmentStates.BETA)
        {
            DevelopmentInformation developmentInformation = new DevelopmentInformation();

            try
            {
                switch (state)
                {
                    case DevelopmentStates.PREALPHA:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { developmentInformation.InternalVersion.Build.ToString() } - Pre-Alpha)";
                        break;
                    case DevelopmentStates.ALPHA:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { developmentInformation.InternalVersion.Build.ToString() } - Alpha)";
                        break;
                    case DevelopmentStates.BETA:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { developmentInformation.InternalVersion.Build.ToString() } - Beta)";
                        break;
                    case DevelopmentStates.RTM:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { developmentInformation.InternalVersion.Build.ToString() } - RTM)";
                        break;
                    case DevelopmentStates.CURRENT:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { developmentInformation.InternalVersion.Build.ToString() } - Current Build)";
                        break;
                    case DevelopmentStates.EOL:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { developmentInformation.InternalVersion.Build.ToString() } - End of Life)";
                        break;
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        public static void SetBuildInformation(KryptonForm target, Assembly assembly, DevelopmentStates state = DevelopmentStates.BETA)
        {
            DevelopmentInformation developmentInformation = new DevelopmentInformation();

            try
            {
                switch (state)
                {
                    case DevelopmentStates.PREALPHA:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { GetAssemblyVersion(assembly).Build.ToString() } - Pre-Alpha)";
                        break;
                    case DevelopmentStates.ALPHA:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { GetAssemblyVersion(assembly).Build.ToString() } - Alpha)";
                        break;
                    case DevelopmentStates.BETA:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { GetAssemblyVersion(assembly).Build.ToString() } - Beta)";
                        break;
                    case DevelopmentStates.RTM:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { GetAssemblyVersion(assembly).Build.ToString() } - RTM)";
                        break;
                    case DevelopmentStates.CURRENT:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { GetAssemblyVersion(assembly).Build.ToString() } - Current Build)";
                        break;
                    case DevelopmentStates.EOL:
                        target.TextExtra = $"({ CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month + 1) } { DateTime.Now.Year.ToString() } Update - Build: { GetAssemblyVersion(assembly).Build.ToString() } - End of Life)";
                        break;
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        public static FileInfo GetFileInfomation(string filePath)
        {
            return new FileInfo(filePath);
        }

        public static FileVersionInfo GetFileVersionInformation(string filePath)
        {
            return FileVersionInfo.GetVersionInfo(filePath);
        }

        public static Version GetFileVersion(FileVersionInfo fileVersionInfo)
        {
            return Version.Parse(fileVersionInfo.ProductVersion);
        }

        public static Version GetAssemblyVersion(Assembly executablePath)
        {
            return executablePath.GetName().Version;
        }
        #endregion
    }
}