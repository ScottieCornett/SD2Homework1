using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    public class CreateBuilding<T> : Building
    {
        private readonly List<T> Buildings = new List<T>();
        //private BuildingConstructor? buildingConstructor;
        public void CreateNewBuilding(T building)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();
            var buildingConstructor = new BuildingConstructor();

            var permitRepo = new ZoningAndPermitRepo();

            var apartmentWasMade = buildingConstructor.ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());
            var highRiseWasMade = buildingConstructor.ConstructBuilding<HighRise>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (apartmentWasMade || highRiseWasMade)
            {
                Buildings.Add(building);
            }
        }
    }
}
