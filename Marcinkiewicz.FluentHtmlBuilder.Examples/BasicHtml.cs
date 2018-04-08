using System;

namespace Marcinkiewicz.FluentHtmlBuilder.Examples
{
    /// <summary>
    /// Basic usage of FluentHtmlBuilder
    /// </summary>
    internal static class BasicHtml
    {
        /// <summary>
        /// Build simple html document
        /// </summary>
        /// <returns>String containing HTML document content</returns>
        internal static string Build()
        {
            // Define Styles

            // Define header style
            InlineStyles h1Style = new InlineStyles();
            h1Style.AddStyle("color", "red");
            h1Style.AddStyle("text-decoration", "underline");

            // Create merged style
            InlineStyles h2Style = new InlineStyles();
            h2Style.AddStyle("font-size", "5px");
            h2Style.MergeWith(h1Style, false);

            // Table style configuration
            Action<InlineStyles> tableStyleCfg = (stylesCfg) =>
            {
                stylesCfg.AddStyle("background", "blue");
            };

            // Row style configuration
            Action<InlineStyles> rowStyleCfg = (stylesCfg) =>
            {
                stylesCfg.AddStyle("color", "green");
            };

            // Cell (merged) style configuration
            Action<InlineStyles> cellStyleCfg = tableStyleCfg + rowStyleCfg;

            // Build HTML

            // Create root element
            HtmlDocument document = new HtmlDocument();

            // Add body to the document
            document.AddBody(body =>
            {
                // Add header with Hello world text
                body.AddHeader(header =>
                {
                    header.AddContent("Hello world");
                }, h1Style);

                // Add table
                body.AddTable(table =>
                {
                    table.AddBody(tbody =>
                    {
                        // Add 10 rows
                        for (int i = 0; i < 10; i++)
                        {
                            tbody.AddRow(trow =>
                            {
                                trow.AddCell(tcell =>
                                {
                                    tcell.AddContent($"Column in row {i}");
                                }, cellStyleCfg);
                            }, rowStyleCfg);
                        }
                    }, tableStyleCfg);
                },
                styles =>
                {
                    styles.AddStyle("background", "yellow");
                });
            }, (InlineStyles)null);

            return document.ToString();

/* --------------------------------------
RESULT:
<html>
<body>
    <h1 style="color: red; text-decoration: underline; ">Hello world</h1>
    <table style="background: yellow; ">
        <tbody style="background: blue; ">
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 0</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 1</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 2</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 3</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 4</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 5</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 6</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 7</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 8</td>
            </tr>
            <tr style="color: green; ">
                <td style="background: blue; color: green; ">Column in row 9</td>
            </tr>
        </tbody>
    </table>
</body>
</html>
-------------------------------------- */
        }
    }
}
