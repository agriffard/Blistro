using Blistro.Models;
using Fluid;

namespace Blistro.Services;

public sealed class LiquidRenderer
{
    private readonly FluidParser _parser = new();

    public async Task<string> RenderAsync(string templateText, object model)
    {
        if (!_parser.TryParse(templateText, out var template, out var error))
        {
            throw new InvalidOperationException($"Liquid parse error: {error}");
        }

        var options = new TemplateOptions();
        RegisterModelTypes(options);

        var context = new TemplateContext(model, options);
        return await template.RenderAsync(context);
    }

    private static void RegisterModelTypes(TemplateOptions options)
    {
        options.MemberAccessStrategy.Register<AboutModel>();
        options.MemberAccessStrategy.Register<ContactInfo>();
        options.MemberAccessStrategy.Register<GalleryImage>();
        options.MemberAccessStrategy.Register<GalleryModel>();
        options.MemberAccessStrategy.Register<HeroInfo>();
        options.MemberAccessStrategy.Register<HoursInfo>();
        options.MemberAccessStrategy.Register<MapInfo>();
        options.MemberAccessStrategy.Register<MenuCategory>();
        options.MemberAccessStrategy.Register<MenuItemModel>();
        options.MemberAccessStrategy.Register<MenuModel>();
        options.MemberAccessStrategy.Register<RestaurantModel>();
        options.MemberAccessStrategy.Register<SocialLinkInfo>();
    }
}
