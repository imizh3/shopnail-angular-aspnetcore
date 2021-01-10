using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB2020.Model
{
    public class Categorys
    {
        /**
     * Item Title
     * @type {string}
     */
        public string title { get; set; }
        /**
         * Item relative link (for routerLink)
         * @type {string}
         */
        public string link { get; set; }
        /**
         * Item URL (absolute)
         * @type {string}
         */
        public string url { get; set; }
        /**
         * Icon class name or icon config object
         * @type {string | NbIconConfig}
         */
        public string icon { get; set; }
        /**
         * Expanded by default
         * @type {boolean}
         */
        public bool expanded { get; set; }
        /**
         * Children items
         * @type {List<NbMenuItem>}
         */
        public object queryParams { get; set; }
        public List<Categorys> children { get; set; }

    }
}
