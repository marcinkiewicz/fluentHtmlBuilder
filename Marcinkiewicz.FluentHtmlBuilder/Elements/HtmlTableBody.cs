using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <tbody></tbody>
    /// </summary>
    public class HtmlTableBody : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableBody"/> class.
        /// </summary>
        public HtmlTableBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableBody"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlTableBody(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"tbody";

        /// <summary>
        /// Add <tr></tr> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddRow(Action<HtmlTableRow> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlTableRow, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <tr></tr> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddRow(Action<HtmlTableRow> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlTableRow, InlineStyles>(elementCfg, styles);
    }
}
