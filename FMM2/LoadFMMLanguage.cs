﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FMM2
{
    public partial class MainWindow : Window
    {
        private void loadFMMLang()
        {
            if (!File.Exists("FMM_Lang.ini"))
            {
                try
                {
                    using (new FileStream("FMM_Lang.ini", FileMode.CreateNew)) { }
                }
                catch {
                    MessageBox.Show("Couldn't create FMM_Lang.ini file.");
                }
            }


            //if (string.IsNullOrEmpty(readFMMLang("Title")))
            //{
            //    writeFMMLang("Title", this.Title);
            //}
            //else
            //{
            //    this.Title = readFMMLang("Title");
            //}

            if (string.IsNullOrEmpty(readFMMLang("Tab_MyMods")))
            {
                writeFMMLang("Tab_MyMods", myModsTab.Header.ToString());
            }
            else
            {
                myModsTab.Header = readFMMLang("Tab_MyMods");
            }

            if (string.IsNullOrEmpty(readFMMLang("Tab_DownloadableMods")))
            {
                writeFMMLang("Tab_DownloadableMods", downloadableModsTab.Header.ToString());
            }
            else
            {
                downloadableModsTab.Header = readFMMLang("Tab_DownloadableMods");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_File")))
            {
                writeFMMLang("Menu_File", file.Header.ToString());
            }
            else
            {
                file.Header = readFMMLang("Menu_File");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_FileAbout")))
            {
                writeFMMLang("Menu_FileAbout", fileAbout.Header.ToString());
            }
            else
            {
                fileAbout.Header = readFMMLang("Menu_FileAbout");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_FileExit")))
            {
                writeFMMLang("Menu_FileExit", fileExit.Header.ToString());
            }
            else
            {
                fileExit.Header = readFMMLang("Menu_FileExit");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_Options")))
            {
                writeFMMLang("Menu_Options", options.Header.ToString());
            }
            else
            {
                options.Header = readFMMLang("Menu_Options");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_OptionsListOrder")))
            {
                writeFMMLang("Menu_OptionsListOrder", optionsOrder.Header.ToString());
            }
            else
            {
                optionsOrder.Header = readFMMLang("Menu_OptionsListOrder");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_OptionsInstallOrder")))
            {
                writeFMMLang("Menu_OptionsInstallOrder", optionsOrderList.Header.ToString());
            }
            else
            {
                optionsOrderList.Header = readFMMLang("Menu_OptionsInstallOrder");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_OptionsPriorityOrder")))
            {
                writeFMMLang("Menu_OptionsPriorityOrder", optionsOrderPriority.Header.ToString());
            }
            else
            {
                optionsOrderPriority.Header = readFMMLang("Menu_OptionsPriorityOrder");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_OptionsDeveloperOptions")))
            {
                writeFMMLang("Menu_OptionsDeveloperOptions", optionsDeveloperOptions.Header.ToString());
            }
            else
            {
                optionsDeveloperOptions.Header = readFMMLang("Menu_OptionsDeveloperOptions");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_OptionsDeveloperBackup")))
            {
                writeFMMLang("Menu_OptionsDeveloperBackup", optionsDeveloperBackup.Header.ToString());
            }
            else
            {
                optionsDeveloperBackup.Header = readFMMLang("Menu_OptionsDeveloperBackup");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_OptionsDeveloperRestore")))
            {
                writeFMMLang("Menu_OptionsDeveloperRestore", optionsDeveloperRestore.Header.ToString());
            }
            else
            {
                optionsDeveloperRestore.Header = readFMMLang("Menu_OptionsDeveloperRestore");
            }

            if (string.IsNullOrEmpty(readFMMLang("Menu_OptionsDeveloperTagTool")))
            {
                writeFMMLang("Menu_OptionsDeveloperTagTool", optionsDeveloperTagTool.Header.ToString());
            }
            else
            {
                optionsDeveloperTagTool.Header = readFMMLang("Menu_OptionsDeveloperTagTool");
            }

            if (string.IsNullOrEmpty(readFMMLang("Alert_InstallOrder")))
            {
                writeFMMLang("Alert_InstallOrder", myModsAlertText.Text);
            }
            else
            {
                myModsAlertText.Text = readFMMLang("Alert_InstallOrder");
            }

            if (string.IsNullOrEmpty(readFMMLang("Alert_RepoDown")))
            {
                writeFMMLang("Alert_RepoDown", downloadableModsAlertText.Text);
            }
            else
            {
                downloadableModsAlertText.Text = readFMMLang("Alert_RepoDown");
            }

            if (string.IsNullOrEmpty(readFMMLang("Header_Name")))
            {
                writeFMMLang("Header_Name", gv1Name.Header.ToString());
            }
            else
            {
                gv1Name.Header = readFMMLang("Header_Name");
                gv2Name.Header = readFMMLang("Header_Name");
            }

            if (string.IsNullOrEmpty(readFMMLang("Header_Author")))
            {
                writeFMMLang("Header_Author", gv1Author.Header.ToString());
            }
            else
            {
                gv1Author.Header = readFMMLang("Header_Author");
                gv2Author.Header = readFMMLang("Header_Author");
            }

            if (string.IsNullOrEmpty(readFMMLang("Header_Version")))
            {
                writeFMMLang("Header_Version", gv1Version.Header.ToString());
            }
            else
            {
                gv1Version.Header = readFMMLang("Header_Version");
                gv2Version.Header = readFMMLang("Header_Version");
            }

            if (string.IsNullOrEmpty(readFMMLang("Header_Description")))
            {
                writeFMMLang("Header_Description", gv1Description.Header.ToString());
            }
            else
            {
                gv1Description.Header = readFMMLang("Header_Description");
                gv2Description.Header = readFMMLang("Header_Description");
            }

            if (string.IsNullOrEmpty(readFMMLang("Header_Warnings")))
            {
                writeFMMLang("Header_Warnings", gv1Warnings.Header.ToString());
            }
            else
            {
                gv1Warnings.Header = readFMMLang("Header_Warnings");
                gv2Warnings.Header = readFMMLang("Header_Warnings");
            }

            if (string.IsNullOrEmpty(readFMMLang("Button_Refresh")))
            {
                writeFMMLang("Button_Refresh", refreshString);
            }
            else
            {
                myModsRefreshButton.Content = readFMMLang("Button_Refresh");
                dlModsRefreshButton.Content = readFMMLang("Button_Refresh");
                refreshString = readFMMLang("Button_Refresh");
            }

            if (string.IsNullOrEmpty(readFMMLang("Button_Loading")))
            {
                writeFMMLang("Button_Loading", loadingString);
            }
            else
            {
                loadingString = readFMMLang("Button_Loading");
            }

            if (string.IsNullOrEmpty(readFMMLang("Button_ApplyCheckedMods")))
            {
                writeFMMLang("Button_ApplyCheckedMods", infobarApply.Content.ToString());
            }
            else
            {
                infobarApply.Content = readFMMLang("Button_ApplyCheckedMods");
            }

            if (string.IsNullOrEmpty(readFMMLang("Button_DownloadCheckedMods")))
            {
                writeFMMLang("Button_DownloadCheckedMods", infobarDLDownload.Content.ToString());
            }
            else
            {
                infobarDLDownload.Content = readFMMLang("Button_DownloadCheckedMods");
            }

            if (string.IsNullOrEmpty(readFMMLang("String_ModAvailable")))
            {
                writeFMMLang("String_ModAvailable", modAvailable);
            }
            else
            {
                modAvailable = readFMMLang("String_ModAvailable");
            }

            if (string.IsNullOrEmpty(readFMMLang("String_ModsAvailable")))
            {
                writeFMMLang("String_ModsAvailable", modsAvailable);
            }
            else
            {
                modsAvailable = readFMMLang("String_ModsAvailable");
                myModsStatusNumber.Content = "0 " + modsAvailable;
                dlModsStatusNumber.Content = "0 " + modsAvailable;
            }
            
            if (string.IsNullOrEmpty(readFMMLang("MB_ConfirmDelete")))
            {
                writeFMMLang("MB_ConfirmDelete", sureyouwanttodelete);
            }
            else
            {
                sureyouwanttodelete = readFMMLang("MB_ConfirmDelete");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_CantUndo")))
            {
                writeFMMLang("MB_CantUndo", thiscannotbeundone);
            }
            else
            {
                thiscannotbeundone = readFMMLang("MB_CantUndo");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_FailedDeploy")))
            {
                writeFMMLang("MB_FailedDeploy", faileddeploy);
            }
            else
            {
                faileddeploy = readFMMLang("MB_FailedDeploy");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_DevsDontSupport")))
            {
                writeFMMLang("MB_DevsDontSupport", modsnotsupported);
            }
            else
            {
                modsnotsupported = readFMMLang("MB_DevsDontSupport");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_DevsDontSupport")))
            {
                writeFMMLang("MB_DevsDontSupport", modsnotsupported);
            }
            else
            {
                modsnotsupported = readFMMLang("MB_DevsDontSupport");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_ReportToCreators")))
            {
                writeFMMLang("MB_ReportToCreators", ifbugsexperienced);
            }
            else
            {
                ifbugsexperienced = readFMMLang("MB_ReportToCreators");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_WontAcceptBugs")))
            {
                writeFMMLang("MB_WontAcceptBugs", wontacceptsusp);
            }
            else
            {
                wontacceptsusp = readFMMLang("MB_WontAcceptBugs");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_FMMCurrentlyWorking")))
            {
                writeFMMLang("MB_FMMCurrentlyWorking", fmmcurrentlyworking);
            }
            else
            {
                fmmcurrentlyworking = readFMMLang("MB_FMMCurrentlyWorking");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_ConfirmQuit")))
            {
                writeFMMLang("MB_ConfirmQuit", areyousurequit);
            }
            else
            {
                areyousurequit = readFMMLang("MB_ConfirmQuit");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_ModsDownloaded")))
            {
                writeFMMLang("MB_ModsDownloaded", modsdownloaded);
            }
            else
            {
                modsdownloaded = readFMMLang("MB_ModsDownloaded");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_BackupRestored")))
            {
                writeFMMLang("MB_BackupRestored", backuprestored);
            }
            else
            {
                backuprestored = readFMMLang("MB_BackupRestored");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_ErrorInstalling")))
            {
                writeFMMLang("MB_ErrorInstalling", errorinstalling);
            }
            else
            {
                errorinstalling = readFMMLang("MB_ErrorInstalling");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_ConsultDiscord")))
            {
                writeFMMLang("MB_ConsultDiscord", pleaseconsultdiscord);
            }
            else
            {
                pleaseconsultdiscord = readFMMLang("MB_ConsultDiscord");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_CheckedModsInstalled")))
            {
                writeFMMLang("MB_CheckedModsInstalled", checkedmodsinstalled);
            }
            else
            {
                checkedmodsinstalled = readFMMLang("MB_CheckedModsInstalled");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_FilesInUse")))
            {
                writeFMMLang("MB_FilesInUse", filesinuse);
            }
            else
            {
                filesinuse = readFMMLang("MB_FilesInUse");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_ConfirmApply")))
            {
                writeFMMLang("MB_ConfirmApply", yousureapply);
            }
            else
            {
                yousureapply = readFMMLang("MB_ConfirmApply");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_UnsafeLocations")))
            {
                writeFMMLang("MB_UnsafeLocations", unsafelocations);
            }
            else
            {
                unsafelocations = readFMMLang("MB_UnsafeLocations");
            }

            if (string.IsNullOrEmpty(readFMMLang("MB_PleaseCheckMods")))
            {
                writeFMMLang("MB_PleaseCheckMods", pleasecheckmods);
            }
            else
            {
                pleasecheckmods = readFMMLang("MB_PleaseCheckMods");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_DLSuccess")))
            {
                writeFMMLang("Log_DLSuccess", moddlsuccess);
            }
            else
            {
                moddlsuccess = readFMMLang("Log_DLSuccess");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_DLFailed")))
            {
                writeFMMLang("Log_DLFailed", moddlfailed);
            }
            else
            {
                moddlfailed = readFMMLang("Log_DLFailed");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_BakCreateSuccess")))
            {
                writeFMMLang("Log_BakCreateSuccess", bakcreatesuccess);
            }
            else
            {
                bakcreatesuccess = readFMMLang("Log_BakCreateSuccess");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_BakCreateFailed")))
            {
                writeFMMLang("Log_BakCreateFailed", bakcreatefailed);
            }
            else
            {
                bakcreatefailed = readFMMLang("Log_BakCreateFailed");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_BakRestoreSuccess")))
            {
                writeFMMLang("Log_BakRestoreSuccess", bakrestoresuccess);
            }
            else
            {
                bakrestoresuccess = readFMMLang("Log_BakRestoreSuccess");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_BakRestoreFailed")))
            {
                writeFMMLang("Log_BakRestoreFailed", bakrestorefailed);
            }
            else
            {
                bakrestorefailed = readFMMLang("Log_BakRestoreFailed");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_DownloadingMods")))
            {
                writeFMMLang("Log_DownloadingMods", downloadingmods);
            }
            else
            {
                downloadingmods = readFMMLang("Log_DownloadingMods");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_InstallingMods")))
            {
                writeFMMLang("Log_InstallingMods", installingmods);
            }
            else
            {
                installingmods = readFMMLang("Log_InstallingMods");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_PreparingBackup")))
            {
                writeFMMLang("Log_PreparingBackup", preparingbackup);
            }
            else
            {
                preparingbackup = readFMMLang("Log_PreparingBackup");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_RestoringBackup")))
            {
                writeFMMLang("Log_RestoringBackup", restoringbackup);
            }
            else
            {
                restoringbackup = readFMMLang("Log_RestoringBackup");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_CreatingBackup")))
            {
                writeFMMLang("Log_CreatingBackup", creatingbackup);
            }
            else
            {
                creatingbackup = readFMMLang("Log_CreatingBackup");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_CleanFilesBacked")))
            {
                writeFMMLang("Log_CleanFilesBacked", cleanfilesbacked);
            }
            else
            {
                cleanfilesbacked = readFMMLang("Log_CleanFilesBacked");
            }

            if (string.IsNullOrEmpty(readFMMLang("Log_DeveloperSkip")))
            {
                writeFMMLang("Log_DeveloperSkip", skippeddev);
            }
            else
            {
                skippeddev = readFMMLang("Log_DeveloperSkip");
            }
        }
    }
}
