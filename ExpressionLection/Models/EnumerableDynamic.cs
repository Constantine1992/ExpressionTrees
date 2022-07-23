using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionLection.Models
{
    public static class EnumerableDynamic
    {
        /// <summary>
        /// Сортировка IEnumerable<TSource> Expression.Call
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="sequence"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> OrderBy<TSource>(this IEnumerable<TSource> sequence, string propertyName)
        {            
            // Построение lambda x => x.Property
            ParameterExpression xParameter = Expression.Parameter(typeof(TSource),"x");
            MemberExpression property = Expression.Property(xParameter, propertyName);
            LambdaExpression expression = Expression.Lambda(property, xParameter);
           
            // Статический метод OrderBy класса Enumerable
            Type enumerableType = typeof(Enumerable);
            MethodInfo orderBy = enumerableType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                                                .Where(method => method.Name == "OrderBy" &&
                                                                 method.GetParameters().Count() == 2).FirstOrDefault();
            orderBy = orderBy.MakeGenericMethod(typeof(TSource), property.Type);

            // Вызов метода OrderBy
            ConstantExpression sourceConstant = Expression.Constant(sequence, typeof(IEnumerable<TSource>));

            MethodCallExpression callMethodOrderBy = Expression.Call(orderBy, sourceConstant, expression);
            LambdaExpression lambda = Expression.Lambda(callMethodOrderBy);
            Func<IEnumerable<TSource>> compiledLamda = (Func<IEnumerable<TSource>>) lambda.Compile();

            //MethodInfo orderBy
            IEnumerable<TSource> result = compiledLamda();// Enumerable.OrderBy(sources, x=>x.Property);

            return result;
        }
        /// <summary>
        /// Сортировка IEnumerable<TSource> Reflection Invoke
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="sequence"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> OrderBy2<TSource>(this IEnumerable<TSource> sequence, string propertyName)
        {
            // Построение lambda x => x.Property
            ParameterExpression x = Expression.Parameter(typeof(TSource), "x");
            MemberExpression property = Expression.Property(x, propertyName);
            LambdaExpression expression = Expression.Lambda(property, x);
            Delegate compiledLambda = expression.Compile(); 

            // Статический метод OrderBy класса Enumerable
            Type queryableType = typeof(Enumerable);
            MethodInfo orderBy = queryableType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                                               .Where(method => method.Name == "OrderBy" &&
                                                                method.GetParameters().Count() == 2).FirstOrDefault();
            // Определение параметров типов
            orderBy = orderBy.MakeGenericMethod(typeof(TSource), property.Type);

            IEnumerable<TSource> result = orderBy.Invoke(null, new object[] {sequence, compiledLambda}) as IEnumerable<TSource>;
            
            
            return result; 
        }
        /// <summary>
        /// Сортировка IQueryable<TSource> Reflection Invoke
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="sequence"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static IQueryable<TSource> OrderBy<TSource>(this IQueryable<TSource> sequence, string propertyName)
        {
            // Построение lambda x => x.Property
            ParameterExpression x = Expression.Parameter(typeof(TSource), "x");
            MemberExpression property = Expression.Property(x, propertyName);
            LambdaExpression expression = Expression.Lambda(property, x);
            //  Delegate compiledLambda = expression.Compile();

            // Статический метод OrderBy класса Enumerable
            Type enumerableType = typeof(Queryable);
            MethodInfo orderBy = enumerableType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                                               .Where(method => method.Name == "OrderBy" &&
                                                                method.GetParameters().Count() == 2).FirstOrDefault();
            // Определение параметров типов
            orderBy = orderBy.MakeGenericMethod(typeof(TSource), property.Type);

            IQueryable<TSource> result = orderBy.Invoke(null, new object[] { sequence, expression }) as IQueryable<TSource>;

            return result;
        }
        public static IEnumerable<T> OrderByx<T>(this IEnumerable<T> entities, string propertyName)
        {
            if (!entities.Any() || string.IsNullOrEmpty(propertyName))
                return entities;

            PropertyInfo propertyInfo = entities.First()
                                                .GetType()
                                                .GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            return entities.OrderBy(e => propertyInfo.GetValue(e, null));
        }
    }
}
