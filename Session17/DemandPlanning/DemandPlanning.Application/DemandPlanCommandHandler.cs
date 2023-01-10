using DemandPlanning.Domain.Model.Plan;
using DemandPlanning.Domain.Model.Plan.Builders;

namespace DemandPlanning.Application
{
    public class DemandPlanCommandHandler
    {
        public void SchedulePlan()
        {
           var plan = Schedule.Plan().From(DateTime.Now).Until(DateTime.Now.AddDays(30))
               .AddWeek()
                    .AddToDay(DayOfWeek.Monday, new Demand(new ProductId(1), 100, "KG"))
                    .AddToDay(DayOfWeek.Monday, new Demand(new ProductId(1), 100, "KG"))
                    .AddToDay(DayOfWeek.Monday, new Demand(new ProductId(1), 100, "KG"))
               .AddWeek()
                    .AddToDay(DayOfWeek.Monday, new Demand(new ProductId(1), 100, "KG"))
               .Build();
        }

        public void CopyAPlan()
        {
            var plan = LoadFromDatabase();
            plan.MakeACopyAppendingThisPlan();
            //planRepository.Add(plan);
        }

        private DemandPlan LoadFromDatabase()
        {
            throw new NotImplementedException();
        }
    }
}