using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp.Mapper
{
    public static class MyMapper
    {
        //public TTarget Map<TSource, TTarget>(TSource source) where TTarget : new()
        //{
        //    var target = new TTarget();
        //    foreach (var targetProperty in (typeof(TTarget)).GetProperties())
        //    {
        //        var sourceProperty = typeof(TSource).GetProperty(targetProperty.Name);
        //        if (sourceProperty == null) continue;
        //        if (sourceProperty.PropertyType != targetProperty.PropertyType) continue;

        //        var sourceValue = sourceProperty.GetValue(source);
        //        targetProperty.SetValue(target, sourceValue);
        //    }
        //}
    }
}
