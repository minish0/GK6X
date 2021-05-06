using System;

namespace GK6X
{
    public class GK6XMessages {
        public const string loadlocalizationdataError = "Failed to load localization data";
        public const string loadKeydataError = "Failed to load the key data";
        public const string loadKeyboardDataError = "Failed to load keyboard data";
        public const string connectDeviceFmt = "Connected to device '{0}' model: {1} fw: {2}";
        public const string disconnectDeviceFmt = "Disconnected from device '{0}'";
        public const string commandReadError = "Cannot read from command line. Exiting.";
        public const string directoryEvalError = "Bad input. Expected folder name.";
        public const string updateDataMsg = "done";
        public const string updateDataErrorFmt = "Couldn't find path '{0}'";
        public const string gui2txtError = "Load GUI first";
        public const string gui2txtMapError = "Failed to map index {0} to {1} on layer {2}";
        public const string gui2txtSave = "Done";
        public const string gui2txtAccountSettingsErrorFmt = "Account settings not found for account id {0}";
        public const string guiLECopiedFmt = "Copied '{0}'";
        public const string guiLECSErrorFmt = "Failed to find lighting effect '{0}' (it's case sensitive)";
        public const string guiLEFileFindErrorFmt = "Failed to find file '{0}'";
        public const string guiLEInvalidInput = "Invalid input. Expected lighting effect name.";
        public const string findkeysMessageFmt = "{0}"
           + "This is used to identify keys. Press keys to see their values."
           + " Missing keys will generally show up as '(null)' and they need to be mapped in the data files Data/devuces/YOUR_MODEL_ID/"
           + "{0}"
           + "The 'S' values are what you want to use to map keys in your UserData file."
           + "{0}"
          + "Entering 'driver' mode and mapping all keys to callbacks.";
        public const string mapUserDataFileLoadErrorFmt = "Couldn't find user data file '{0}'";
        public const string mapUserDataFileLoad = "Done";
        public const string dumpkeysHeaderFmt = "====== {0} ======";
        public const string dumpkeysRowSeparator = "--------";
        public const string helpListCommandsFmt = "List of commands:"
            + "{0}"
            + "  close,exit,quit"
            + "{0}"
            + "  cls,clear"
            + "{0}"
            + "  dumpkeys"
            + "{0}"
            + "  findkeys"
            + "{0}"
            + "  help"
            + "{0}"
            + "  gui"
            + "{0}"
            + "  gul_le"
            + "{0}"
            + "  gui_to_txt"
            + "{0}"
            + "  map"
            + "{0}"
            + "  unmap"
            + "{0}"
            + "  update_data";
        public const string noDeviceConnected = "No devices connected!";
        public const string noJSFileToProcess = "Couldn't find formatted js files to process!";
        public const string missingDirectoryOrFile = "Missing directory / file!";
    }
}