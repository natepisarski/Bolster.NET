using System;
using System.Collections.Generic;
using System.Linq;
using Bolster.API.Status;
using Bolster.API.Status.Stateless;
using Bolster.Base;
using Bolster.Base.Interface;

namespace Bolster.API.Interface.Mixed
{
    public static class MixedStatuses
    {
        public static Either<T, W> DeclareActions<T, W>(this Either<T, W> result)
            where T : ISuccess where W : IFailure => result;

        public static Either<T, W> DeclareResults<T, W>(this Either<T, W> result)
            where T : ISuccess where W : IFailure => result; 
        
        public static bool IsSuccess<T, W>(this Either<T, W> status) where T : ISuccess where W : IFailure
            => status.Is<ISuccess>();

        public static bool IsFailure<T, W>(this Either<T, W> status) where T : ISuccess where W : IFailure
            => status.Is<IFailure>();
        
        public static Either<T, W> IfFailure<T, W>(this Either<T, W> result, Action action) where T : ISuccess where W : IFailure {
            if (result.IsFailure()) {
                action.Invoke();
            }
            return result;
        }

        public static Either<T, W> IfSuccess<T, W>(this Either<T, W> result, Action action)
            where T : ISuccess where W : IFailure {
            if (result.IsSuccess()) {
                action.Invoke();
            }
            return result;
        }

        public static Maybe<Z> IfFailure<T, W, Z>(this Either<T, W> result, Func<Z> resultant)
            where T : ISuccess where W : IFailure {
            if (result.Is<IFailure>()) {
                return resultant().Just();
            }
            return new None<Z>();
        }
        
        public static Maybe<Z> IfSuccess<T, W, Z>(this Either<T, W> result, Func<Z> resultant)
            where T : ISuccess where W : IFailure {
            if (result.Is<ISuccess>()) {
                return resultant().Just();
            }
            return new None<Z>();
        }

        public static IEnumerable<Either<T, W>> GetSuccesses<T, W>(this IEnumerable<Either<T, W>> actions)
            where T : ISuccess where W : IFailure
            => actions.Where(x => x.Is<ISuccess>());

        public static IEnumerable<Either<T, W>> GetFailures<T, W>(this IEnumerable<Either<T, W>> actions)
            where T : ISuccess where W : IFailure
            => actions.Where(x => x.Is<IFailure>());
        
        public static bool DidAllSucceed<T, W>(this IEnumerable<Either<T, W>> actions)
            where T: ISuccess where W : IFailure
            => !actions.Any(status => status.Is<IFailure>());
        
        public static bool DidAllFail<T, W>(this IEnumerable<Either<T, W>> actions)
            where T: ISuccess where W : IFailure
            => !actions.Any(status => status.Is<ISuccess>());
        
    }
}