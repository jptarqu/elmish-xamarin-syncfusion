﻿// Copyright 2018 Elmish.XamarinForms contributors. See LICENSE.md for license.
namespace SqueakyApp.iOS

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS
open Syncfusion.SfCalendar.XForms.iOS

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    override this.FinishedLaunching (app, options) =
        Forms.Init()
        new SfCalendarRenderer() |> ignore
        let appcore = new SqueakyApp.App()
        this.LoadApplication (appcore)
        base.FinishedLaunching(app, options)

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main(args, null, "AppDelegate")
        0

