using System.Net.Http.Json;

namespace Blistro.Services;

public sealed class ContentService(HttpClient http, LiquidRenderer renderer)
{
    public async Task<string> RenderSectionAsync<T>(string dataPath, string templatePath)
    {
        var model = await http.GetFromJsonAsync<T>(dataPath);
        var template = await http.GetStringAsync(templatePath);
        return await renderer.RenderAsync(template, model!);
    }
}
