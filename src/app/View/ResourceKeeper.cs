using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Kivinjari.View
{
    public static class ResourceKeeper
    {
        private static readonly string ViewNamespace = typeof(ResourceKeeper).Namespace;  
        
        public static string Html(string fileName)
        {
            if (!fileName.EndsWith(".html"))
            {
                fileName += ".html";
            }

            return GetFile("Html." + fileName);
        }
        
        private static string GetFile(string fileName)
        {
            string content = null;
            
            var assembly = Assembly.GetEntryAssembly();
            var resStream = assembly.GetManifestResourceStream($"{ViewNamespace}.{fileName}");
            
            using (var reader = new StreamReader(resStream))
            {
                content = reader.ReadToEnd();
            }

            return content;
        } 
        
        
        private static async Task<string> GetFileAsync(string fileName)
        {
            Task<string> content = null;
            
            var assembly = Assembly.GetEntryAssembly();
            var resStream = assembly.GetManifestResourceStream($"{ViewNamespace}.{fileName}");
            
            using (var reader = new StreamReader(resStream))
            {
                content = reader.ReadToEndAsync();
            }

            return await content;
        } 
    }
}