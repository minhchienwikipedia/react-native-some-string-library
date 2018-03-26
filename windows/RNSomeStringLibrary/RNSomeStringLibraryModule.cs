using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Some.String.Library.RNSomeStringLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSomeStringLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSomeStringLibraryModule"/>.
        /// </summary>
        internal RNSomeStringLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSomeStringLibrary";
            }
        }
    }
}
