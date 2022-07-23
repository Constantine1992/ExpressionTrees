using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BuildExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> lambda = (x, y) =>  (x + y)*2;
            int result = lambda(5, 4);
            Console.WriteLine(string.Format("Результат выполнения лямбда выражения: {0}", result));
            
            ConstantExpression constant = Expression.Constant(2, typeof(int));
            ParameterExpression paramY = Expression.Parameter(typeof(int), "y");
            ParameterExpression paramX = Expression.Parameter(typeof(int),"x");

            Expression plusExpression = Expression.Add(paramX, paramY);
            Expression multyExpression =  Expression.Multiply(plusExpression, constant);

            LambdaExpression lambdaExpression = null;

            Console.WriteLine("Разделить на 2? y-да n - нет");
            char symbol = Console.ReadKey().KeyChar;
            if (symbol == 'y')
            {
                ConstantExpression enterConstant = Expression.Constant(2, typeof(int));
                Expression divideExpression = Expression.Divide(multyExpression, enterConstant);
                lambdaExpression = Expression.Lambda(divideExpression, paramX, paramY);
            }
            else
            {
                lambdaExpression = Expression.Lambda(multyExpression, paramX, paramY);
            }

            Console.WriteLine("LambdaBody "+lambdaExpression.ToString());
            Func<int, int, int> transformLambda = (Func<int, int, int>)lambdaExpression.Compile();
            int resultTransform = transformLambda(5, 4);
            Console.WriteLine(string.Format("Результат выполнения составленого выражения: {0}", resultTransform ));
            
            
            #region
           
            #endregion

            Console.ReadLine();
        }
    }
}
