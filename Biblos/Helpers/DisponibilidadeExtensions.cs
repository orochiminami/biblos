using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq.Expressions;

namespace Biblos.Helpers
{
    public static class DisponibilidadeExtensions
    {
        public static string DisponivelFor<Livro>(this IHtmlHelper<Livro> html, Expression<Func<Livro, bool>> disp)
        {
            var all = disp.Compile().Invoke(html.ViewData.Model);
            return all ? "Disponível" : "Indisponível";
        }
    }
}
