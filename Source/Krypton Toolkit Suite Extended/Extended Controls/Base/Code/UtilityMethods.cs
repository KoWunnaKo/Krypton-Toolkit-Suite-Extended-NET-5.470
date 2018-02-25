﻿using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code
{
    public class UtilityMethods
    {
        #region Constructor
        /// <summary>
        /// Initialises a new instance of <see cref="UtilityMethods"/>.
        /// </summary>
        public UtilityMethods()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Elevates the application to use administrative privileges. To be used with <see cref="ExtendedToolkit.Controls.KryptonUACShieldButton"/> or <see cref="ExtendedToolkit.ToolstripControls.ToolStripMenuItemUACSheld"/> button click.
        /// </summary>
        /// <param name="processName">The process name that you wish to elevate.</param>
        public void ElevateProcessWithAdministrativeRights(string processName)
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            bool hasAdministrativeRight = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!hasAdministrativeRight)
            {
                // Relaunch the application with administrative rights
                ProcessStartInfo processStartInfo = new ProcessStartInfo();

                processStartInfo.Verb = "runas";

                processStartInfo.FileName = processName;

                try
                {
                    Process.Start(processStartInfo);
                }
                catch (Win32Exception wexc)
                {
                    KryptonMessageBox.Show("Error: " + wexc.Message, "An Error has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }
        }
        #endregion
    }
}