﻿using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

namespace app
{
    public class MyApp : NetDaemonApp
    {
        //public override Task InitializeAsync()
        //{
            
        //    await ListenState("light.tomas_rum", OnTomasRoomChanged);

        //    //await Action
        //    //        .TurnOff
        //    //            .Entities(
        //    //            "light.mylight", 
        //    //            "light.yourlight"
        //    //            )
        //    //                .UsingAttribute("brightness", 50).And
        //    //        .TurnOff
        //    //            .Entity("light.otherlight")
        //    //        .ExecuteAsync();
        //}

        private async Task OnTomasRoomChanged(string entityId, EntityState newState, EntityState oldState )
        {
            Log("Tomas light changed!");
            Log($"New state = {newState.State}");

            await TurnOnAsync("light.vardagsrummet", 
                ("brightness", "100"), ("color_temp", 123));

            //await And("light.vardagsrummet")
            //    .TurnOn(
            //        ("brightness", 50), 
            //        ("color_temp", 123)
            //    );


            //await And("light.vardagsrummet")
            //    .TurnOn()
            //        .Attribute.brightness = 50
            //        .Attribute.color_temp = 123;



            await Task.Delay(10);
        }
    }
}