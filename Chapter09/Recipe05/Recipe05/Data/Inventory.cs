using Recipe05.Models;
using System.Collections.Generic;


namespace Recipe05.Data
{
    public class Inventory
    {
        public IList<GuitarBody> GuitarBodies = new List<GuitarBody>
        {
            new GuitarBody {
                Name = "Red Les Paul",
                AllowBridgePickup =true,
                AllowMiddlePickup =false,
                AllowNeckPickup = true,
                BodyType = BodyType.SolidBody,
                ToneWood = "mahogany" ,
                Color = "Red" ,
                NumberOfStringsSupported =6 ,
                Style = BodyStyle.LesPaul
            },
            new GuitarBody {
                Name = "Green Strat",
                AllowBridgePickup =true,
                AllowMiddlePickup =true,
                AllowNeckPickup = true,
                BodyType = BodyType.SolidBody,
                ToneWood = "basswood" ,
                Color = "Green" ,
                NumberOfStringsSupported = 7 ,
                Style = BodyStyle.Strat
            }
        };

        public IList<GuitarPickup> GuitarPickups = new List<GuitarPickup>
        {
            new GuitarPickup{
                Name = "Imperium 7™ Neck",
                NumberOfStringsSupported =7,
                PickUpType =PickUpType.Humbucker,
                RecommendedPosition = PickUpPosition.Bridge ,
                NumberOfConductorsRequired =4
            },
            new GuitarPickup{
                Name = "DiMarzio® BC-1™",
                NumberOfStringsSupported =6,
                PickUpType =PickUpType.Humbucker,
                RecommendedPosition = PickUpPosition.Bridge ,
                NumberOfConductorsRequired =4
            },
            new GuitarPickup{
                Name = "Area T™ Neck",
                NumberOfStringsSupported =6,
                PickUpType =PickUpType.SingleCoil,
                RecommendedPosition = PickUpPosition.Neck ,
                NumberOfConductorsRequired =4
            },
            new GuitarPickup{
                Name = "Area 67™",
                NumberOfStringsSupported =6,
                PickUpType =PickUpType.SingleCoil,
                RecommendedPosition = PickUpPosition.Middle ,
                NumberOfConductorsRequired =4
            }
        };

        public IList<GuitarString> GuitarStrings = new List<GuitarString>
        {
            new GuitarString { Gage=9, Material = "Steel", NoteAtStandardTuning = "E"},
            new GuitarString {Gage=10, Material = "Nickel", NoteAtStandardTuning = "E"},
            new GuitarString {Gage=11, Material = "Nickel", NoteAtStandardTuning = "B"},
            new GuitarString {Gage=13, Material = "Nickel", NoteAtStandardTuning = "B"},
            new GuitarString {Gage=16, Material = "Nickel", NoteAtStandardTuning = "G"},
            new GuitarString {Gage=17, Material = "Nickel", NoteAtStandardTuning = "G"},
            new GuitarString {Gage=24, Material = "Nickel", NoteAtStandardTuning = "D"},
            new GuitarString {Gage=26, Material = "Nickel", NoteAtStandardTuning = "D"},
            new GuitarString {Gage=32, Material = "Nickel", NoteAtStandardTuning = "A"},
            new GuitarString {Gage=36, Material = "Nickel", NoteAtStandardTuning = "A"},
            new GuitarString {Gage=42, Material = "Nickel", NoteAtStandardTuning = "Low E"},
            new GuitarString {Gage=46, Material = "Nickel", NoteAtStandardTuning = "Low E"},
            new GuitarString {Gage=56, Material = "Nickel", NoteAtStandardTuning = "Low B"}
        };


    }
}
