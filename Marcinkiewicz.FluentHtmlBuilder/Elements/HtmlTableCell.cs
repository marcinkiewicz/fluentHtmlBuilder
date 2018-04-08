using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <td></td>
    /// </summary>
    public class HtmlTableCell : HtmlContainerElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableCell"/> class.
        /// </summary>
        public HtmlTableCell()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTableCell"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlTableCell(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Sets column span value that reprenests <td colspan=""></td>
        /// </summary>
        public int Colspan
        {
            set
            {
                this.CustomElementProperties.Add("colspan", value.ToString());
            }
        }

        /// <summary>
        /// Sets row span value that reprenests <td rowspan=""></td>
        /// </summary>
        public int Rowspan
        {
            set
            {
                this.CustomElementProperties.Add("rowspan", value.ToString());
            }
        }

        /// <inheritdoc />
        protected override string ElementTag => $"td";
    }
}
