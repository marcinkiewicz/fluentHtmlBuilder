using System;

namespace Marcinkiewicz.FluentHtmlBuilder.Abstraction
{
    /// <summary>
    /// Html element aggregating available html elements.
    /// </summary>
    public abstract class HtmlContainerElement : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlContainerElement"/> class.
        /// </summary>
        public HtmlContainerElement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlContainerElement"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlContainerElement(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlContainerElement"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlContainerElement(InlineStyles styles)
            : base(styles)
        {
        }

        /// <summary>
        /// Add <table></table> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddTable(Action<HtmlTable> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlTable, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <table></table> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddTable(Action<HtmlTable> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlTable, InlineStyles>(elementCfg, styles);

        /// <summary>
        /// Add <p></p> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddParagraph(Action<HtmlParagraph> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlParagraph, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <p></p> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddParagraph(Action<HtmlParagraph> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlParagraph, InlineStyles>(elementCfg, styles);

        /// <summary>
        /// Add <h></h> to the list of child elements.
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        /// <remarks>Default indent level is 1.</remarks>
        public void AddHeader(Action<HtmlHeader> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlHeader, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <h></h> to the list of child elements.
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        /// <remarks>Default indent level is 1.</remarks>
        public void AddHeader(Action<HtmlHeader> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlHeader, InlineStyles>(elementCfg, styles);

        /// <summary>
        /// Add <div></div> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddDiv(Action<HtmlDiv> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlDiv, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <div></div> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddDiv(Action<HtmlDiv> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlDiv, InlineStyles>(elementCfg, styles);

        /// <summary>
        /// Add <span></span> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="stylesCfg">Styles configuration</param>
        public void AddSpan(Action<HtmlSpan> elementCfg, Action<InlineStyles> stylesCfg)
            => this.AddChild<HtmlSpan, InlineStyles>(elementCfg, stylesCfg);

        /// <summary>
        /// Add <span></span> to the list of child elements
        /// </summary>
        /// <param name="elementCfg">Element configuration</param>
        /// <param name="styles">Element styles</param>
        public void AddSpan(Action<HtmlSpan> elementCfg, InlineStyles styles)
            => this.AddChild<HtmlSpan, InlineStyles>(elementCfg, styles);
    }
}
