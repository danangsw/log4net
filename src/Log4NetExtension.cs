using log4net;
using System;
using Unity.Extension;
using Unity.Policy;

namespace Unity.log4net
{
    public class Log4NetExtension : UnityContainerExtension
    {
        private static readonly Func<Type, string, string> _defaultGetName = (t, n) => t.FullName;

        public Func<Type, string, string> GetName { get; set; }

        protected override void Initialize()
        {
            // TODO: Context.Policies.Set(typeof(ILog), null, typeof(IBuildPlanPolicy), this);
        }

//        void IBuildPlanPolicy.BuildUp<TContext>(ref TContext context)
//        {
//            Func<Type, string, string> method = GetName ?? _defaultGetName;
//#if NETSTANDARD1_3
//            context.Existing = LogManager.GetLogger(context.ParentContext?.BuildKey.Type);
//#else
//            context.Existing = LogManager.GetLogger(method(context.ParentContext?.BuildKey.Type,
//                                                           context.ParentContext?.BuildKey.Name));
//#endif
//            context.BuildComplete = true;
//        }

    }
}
