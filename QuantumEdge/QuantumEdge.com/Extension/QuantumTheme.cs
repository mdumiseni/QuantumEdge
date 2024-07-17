using MudBlazor;

namespace QuantumEdge.com.Extension;

public static class QuantumTheme
{
    public static MudTheme GetQuantumTheme()
    {
        return new MudTheme()
        {
            PaletteDark = new PaletteDark()
            {
                Primary = "#00C2C7",       // Bright Cyan
                Secondary = "#FF6B6B",     // Soft Coral
                Background = "#F0F2F5",    // Light Gray
                Surface = "#FFFFFF",       // White
                DrawerBackground = "#FFFFFF", // White
                DrawerText = "#333333",    // Charcoal
                AppbarBackground = "#FFFFFF", // White
                AppbarText = "#333333",    // Charcoal
                TextPrimary = "#333333",   // Charcoal
                TextSecondary = "#555555", // Dark Gray
                ActionDefault = "#333333", // Charcoal
                ActionDisabled = "#BDBDBD", // Light Gray
                ActionDisabledBackground = "#E0E0E0", // Very Light Gray
                Divider = "#BDBDBD",       // Light Gray
                DividerLight = "#E0E0E0",  // Very Light Gray
                TableLines = "#E0E0E0",    // Very Light Gray
                LinesDefault = "#BDBDBD",  // Light Gray
                OverlayLight = "#FFFFFF1A" // White with transparency
            },
            PaletteLight = new PaletteLight()
            {
                Primary = "#00C2C7",       // Bright Cyan
                Secondary = "#FF6B6B",     // Soft Coral
                Tertiary = "#594ae1",
                Background = "#F0F2F5",    // Light Gray
                Surface = "#FFFFFF",       // White
                DrawerBackground = "#FFFFFF", // White
                DrawerText = "#333333",    // Charcoal
                AppbarBackground = "#FFFFFF", // White
                AppbarText = "#333333",    // Charcoal
                TextPrimary = "#333333",   // Charcoal
                TextSecondary = "#555555", // Dark Gray
                ActionDefault = "#333333", // Charcoal
                ActionDisabled = "#BDBDBD", // Light Gray
                ActionDisabledBackground = "#E0E0E0", // Very Light Gray
                Divider = "#BDBDBD",       // Light Gray
                DividerLight = "#E0E0E0",  // Very Light Gray
                TableLines = "#E0E0E0",    // Very Light Gray
                LinesDefault = "#BDBDBD",  // Light Gray
                OverlayLight = "#FFFFFF1A" // White with transparency
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "0.875rem",
                    FontWeight = 400,
                    LineHeight = 1.43,
                    LetterSpacing = "0.01071em"
                }, H1 = new H1()
                {
                    FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "3rem",
                    FontWeight = 300,
                    LineHeight = 1.167,
                    LetterSpacing = "-0.01562em"
                },
                H2 = new H2()
                {
                    FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "2.125rem",
                    FontWeight = 300,
                    LineHeight = 1.2,
                    LetterSpacing = "-0.00833em"
                },
            }
        };
    }
}