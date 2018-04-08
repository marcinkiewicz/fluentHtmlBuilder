using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <table></table>
    /// </summary>
    public class HtmlTable : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTable"/> class.
        /// </summary>
        public HtmlTable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTable"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlTable(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTable"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlTable(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"table";

        /// <summary>
        /// Add <thead></thead> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddHead(Action<HtmlTableHead> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlTableHead, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <thead></thead> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddHead(Action<HtmlTableHead> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlTableHead, InlineStyles>(elementCfg, styles);

        /// <summary>
        /// Add <tbody></tbody> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddBody(Action<HtmlTableBody> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlTableBody, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <tbody></tbody> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddBody(Action<HtmlTableBody> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlTableBody, InlineStyles>(elementCfg, styles);
    }
}
