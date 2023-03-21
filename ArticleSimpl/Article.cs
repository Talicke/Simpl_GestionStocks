using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSimpl
{
    internal class Article
    {
        public int Reference { get; set; }
        public string? Nom { get; set; }
        public int? Stock { get; set; }
        public int? Prix { get; set; } 


        public Article()
        {
        
        }

        public override string ToString()
        {
            return $"Référence Article : {this.Reference} \n" +
                $"Nom Article : {this.Nom} \n" +
                $"Stock Article : {this.Stock}\n" +
                $"Prix Article : {this.Prix}\n";
        }

        
    }
}
