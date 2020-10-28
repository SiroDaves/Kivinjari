using System.Collections.Generic;
using System.IO;
using WVCallback = System.Action<Webview.Webview, string>;

namespace Kivinjari.Helpers
{
    public static class Callbacks
    {

        private static readonly Dictionary<string, WVCallback> CallbackDict = new Dictionary<string, WVCallback>();
        
        public static void AddCallback(string name, WVCallback callback)
        {
            CallbackDict.Add(name, callback);
        }

        public static void Handler(Webview.Webview webview, string input)
        {
            var args = input.Split(":");
            if (args.Length != 2)
            {
                throw new InvalidDataException($"ERROR: Webview did send invalid data. The method-data speparator was missing in string: {input}");
            }
            
            CallbackDict[args[0]].Invoke(webview, args[1]);
        }
    }
}