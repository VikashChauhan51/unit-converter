
using System.Collections.Generic;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class PowerConverter : UnitConverterBase
    {
        public PowerConverter() : base(new List<Models.Factor>
        {
            new Factor{
 Value=3.4121411564884,
 Name="BTU/Hour"
 },
new Factor{
 Value=0.00094781698791344,
 Name="BTU/Second"
 },
new Factor{
 Value=0.2388458966275,
 Name="Calories Per Second"
 },
new Factor{
 Value=10000000,
 Name="Erg Per Second"
 },
new Factor{
 Value=0.73756214927727,
 Name="Foot Pound Per Second (ft·lbf/s)"
 },
new Factor{
 Value=1.0E-9,
 Name="Gigawatt (GW)"
 },
new Factor{
 Value=0.001341022089595,
 Name="Horsepower (hp)"
 },
new Factor{
 Value=0.0002388458966275,
 Name="Calorie Per Second"
 },
new Factor{
 Value=0.001,
 Name="Kilowatt (kW)"
 },
new Factor{
 Value=1E-06,
 Name="Megawatt (MW)"
 },
new Factor{
 Value=1000,
 Name="Milliwatt (mW)"
 },
new Factor{
 Value=1,
 Name="Watt (joules/s) (W)"
 }
        })
        {

        }
    }
}
