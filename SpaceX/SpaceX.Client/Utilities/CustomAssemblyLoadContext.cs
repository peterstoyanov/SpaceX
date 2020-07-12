using System.Runtime.Loader;
using System.Reflection;
using System;

namespace SpaceX.Client.Utilities
{
    /// <summary>
    /// Responsible for loading unmanaged dll file libwkhtmltox.dll
    /// Without the file, the DinkToPDF library couldn't be able to generate a PDF Document  
    /// The other two files are also needed - libwkhtmltox.dylib, libwkhtmltox.so
    /// </summary>
    internal class CustomAssemblyLoadContext : AssemblyLoadContext
    {
        public IntPtr LoadUnmanagedLibrary(string absolutePath)
        {
            return LoadUnmanagedDll(absolutePath);
        }
        protected override IntPtr LoadUnmanagedDll(String unmanagedDllName)
        {
            return LoadUnmanagedDllFromPath(unmanagedDllName);
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            throw new NotImplementedException();
        }
    }
}
