using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <tr></tr>
    /// </summary>
    public class HtmlTableRow : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableRow"/> class.
        /// </summary>
        public HtmlTableRow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableRow"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlTableRow(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"tr";

        /// <summary>
        /// Add <td></td> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddCell(Action<HtmlTableCell> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlTableCell, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <td></td> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddCell(Action<HtmlTableCell> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlTableCell, InlineStyles>(elementCfg, styles);
    }
}
