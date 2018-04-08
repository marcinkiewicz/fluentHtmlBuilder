using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <thead></thead>
    /// </summary>
    public class HtmlTableHead : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableHead"/> class.
        /// </summary>
        public HtmlTableHead()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableHead"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlTableHead(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"thead";

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
