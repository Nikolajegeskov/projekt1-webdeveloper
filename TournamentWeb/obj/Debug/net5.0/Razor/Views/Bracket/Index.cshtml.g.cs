#pragma checksum "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\Bracket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dec5926a34cc99be243b5772e4ac694b1e17fbe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bracket_Index), @"mvc.1.0.view", @"/Views/Bracket/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec5926a34cc99be243b5772e4ac694b1e17fbe3", @"/Views/Bracket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbd7db290a5ed2a2e70301dadeeaf346ef9804", @"/Views/_ViewImports.cshtml")]
    public class Views_Bracket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\Bracket\Index.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""Tcontainer"" onmousedown=""mouseDownHandler(event)"">
    <div id=""BracketContainer"">

    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<script>
    let bracketTemplate = { ""Temp1"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": -50, ""dir"": ""END"", ""Next"": 0 }], ""Temp2"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"", ""Next"": 2 }, { ""x"": 100, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"", ""Next"": 2 }, { ""x"": 50, ""y"": 100, ""h"": 100, ""w"": """", ""dir"": ""END"", ""Next"": 0 }], ""Temp3"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"", ""Next"": 3 }, { ""x"": 100, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"", ""Next"": 3 }, { ""x"": 200, ""y"": 0, ""h"": 200, ""w"": 75, ""dir"": ""L"", ""Next"": 4 }, { ""x"": 50, ""y"": 100, ""h"": 100, ""w"": 75, ""dir"": ""R"", ""Next"": 4 }, { ""x"": 125, ""y"": 200, ""h"": 100, ""w"": """", ""dir"": ""END"", ""Match"": 2 }], ""Temp4"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 100, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 200, ""y"": 0, """);
            WriteLiteral(@"h"": 100, ""w"": 50, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 300, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 50, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""R"", ""Match"": 1 }, { ""x"": 250, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""L"", ""Match"": 1 }, { ""x"": 150, ""y"": 200, ""h"": 0, ""w"": """", ""dir"": ""END"", ""Match"": 2 }], ""Temp5"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 100, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 200, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 300, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 400, ""y"": 0, ""h"": 200, ""w"": 75, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 50, ""y"": 100, ""h"": 200, ""w"": 137.5, ""dir"": ""R"", ""Match"": 1 }, { ""x"": 250, ""y"": 100, ""h"": 100, ""w"": 75, ""dir"": ""R"", ""Match"": 1 }, { ""x"": 325, ""y"": 200, ""h"": 100, ""w"": 137.5, ""dir"": ""L"", ""Match"": 2 }, { ""x"": 187.5, ""y"": 300, ""h"": 100, ""w"": """", ""dir"": ""END"", ""Match"": 3 }], ""Temp6"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 100, ""y"": 0, ""h"": 100, ""w"": 50, """);
            WriteLiteral(@"dir"": ""L"" }, { ""x"": 200, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 300, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 400, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 500, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 50, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""R"" }, { ""x"": 250, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""L"" }, { ""x"": 450, ""y"": 100, ""h"": 200, ""w"": 150, ""dir"": ""L"" }, { ""x"": 150, ""y"": 200, ""h"": 100, ""w"": 150, ""dir"": ""R"" }, { ""x"": 300, ""y"": 300, ""h"": 100, ""w"": """", ""dir"": ""END"" }], ""Temp7"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 100, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 200, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 300, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 400, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 500, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 600, ""y"": 0, ""h"": 200, ""w"": 75, ""dir"": ""L"" }, { ""x"": 50, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""R"" }, { ""x"": 250, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""L"" }, { ""x"": 450, ""y"": 100, ""h"": 1");
            WriteLiteral(@"00, ""w"": 75, ""dir"": ""R"" }, { ""x"": 150, ""y"": 200, ""h"": 100, ""w"": 187.5, ""dir"": ""R"" }, { ""x"": 525, ""y"": 200, ""h"": 100, ""w"": 187.5, ""dir"": ""L"" }, { ""x"": 337.5, ""y"": 300, ""h"": 100, ""w"": """", ""dir"": ""END"" }], ""Temp8"": [{ ""x"": 0, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 100, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 200, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 300, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 400, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 500, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 600, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""R"" }, { ""x"": 700, ""y"": 0, ""h"": 100, ""w"": 50, ""dir"": ""L"" }, { ""x"": 50, ""y"": 100, ""h"": 100, ""w"": 150, ""dir"": ""R"" }, { ""x"": 250, ""y"": 100, ""h"": 100, ""w"": 150, ""dir"": ""L"" }, { ""x"": 450, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""R"" }, { ""x"": 650, ""y"": 100, ""h"": 100, ""w"": 100, ""dir"": ""L"" }, { ""x"": 150, ""y"": 200, ""h"": 100, ""w"": 200, ""dir"": ""R"" }, { ""x"": 550, ""y"": 200, ""h"": 100, ""w"": 200, ""dir"": ""L"" }, { ""x"": 350, ""y"": 300, ""h"": 100, ""w"": """", ""dir"": ""END"" ");
            WriteLiteral(@"}] }

    //let patternTemplate = {
    //    ""temp1"": [
    //        {""p1"": ""0""}
    //    ],
    //    ""temp2"": [
    //        { ""p1"": ""0,2"" },
    //        { ""p2"": ""1,2"" }
    //    ],
    //    ""temp3"": [
    //        { ""p1"": ""0,3,4"" },
    //        { ""p2"": ""1,3,4"" },
    //        { ""p3"": ""2,4"" }
    //    ],
    //    ""temp4"": [
    //        { ""p1"": ""0,4,6"" },
    //        { ""p2"": ""1,4,6"" },
    //        { ""p3"": ""2,5,6"" },
    //        { ""p4"": ""2,5,6"" }
    //    ],
    //    ""temp5"": [
    //        { ""p1"": ""0,5,8"" },
    //        { ""p2"": ""1,5,8"" },
    //        { ""p3"": ""2,6,7,8"" },
    //        { ""p4"": ""3,6,7,8"" },
    //        { ""p5"": ""4,7,8"" }
    //    ],
    //    ""temp6"": [
    //        { ""p1"": ""0,6,9,10"" },
    //        { ""p2"": ""1,6,9,10"" },
    //        { ""p3"": ""2,7,9,10"" },
    //        { ""p4"": ""3,7,9,10"" },
    //        { ""p5"": ""4,8,10"" },
    //        { ""p6"": ""5,8,10"" },
    //    ],
    //    ""temp7"": [
    //        { ""p1"": ""0,7,10,12");
            WriteLiteral(@""" },
    //        { ""p2"": ""1,7,10,12"" },
    //        { ""p3"": ""2,8,10,12"" },
    //        { ""p4"": ""3,8,10,12"" },
    //        { ""p5"": ""4,9,11,12"" },
    //        { ""p6"": ""5,9,11,12"" },
    //        { ""p7"": ""6,11,12"" },
    //    ],
    //    ""temp8"": [
    //        { ""p1"": ""0,8,12,14"" },
    //        { ""p2"": ""1,8,12,14"" },
    //        { ""p3"": ""2,9,12,14"" },
    //        { ""p4"": ""3,9,12,14"" },
    //        { ""p5"": ""5,10,13,14"" },
    //        { ""p6"": ""6,10,13,14"" },
    //        { ""p7"": ""7,11,13,14"" },
    //        { ""p8"": ""8,11,13,14"" },
    //    ]
    //}

    let Updates = new Object()

    let patternTemplate = {
        ""temp1"": [
            { ""p1"": ""0"" }
        ],
        ""temp2"": [
            { ""p1"": ""0,2"" },
            { ""p2"": ""1,2"" }
        ],
        ""temp3"": [
            { ""p1"": ""0,3,4"" },
            { ""p2"": ""1,3,4"" },
            { ""p3"": ""2,4"" }
        ],
        ""temp4"": [
            { ""p1"": ""0,4,6"" },
            { ""p2"": ""1,4,6"" },
  ");
            WriteLiteral(@"          { ""p3"": ""2,5,6"" },
            { ""p4"": ""2,5,6"" }
        ],
        ""temp5"": [
            { ""p1"": ""0,5,8"" },
            { ""p2"": ""1,5,8"" },
            { ""p3"": ""2,6,7,8"" },
            { ""p4"": ""3,6,7,8"" },
            { ""p5"": ""4,7,8"" }
        ],
        ""temp6"": [
            { ""p1"": ""0,6,9,10"" },
            { ""p2"": ""1,6,9,10"" },
            { ""p3"": ""2,7,9,10"" },
            { ""p4"": ""3,7,9,10"" },
            { ""p5"": ""4,8,10"" },
            { ""p6"": ""5,8,10"" },
        ],
        ""temp7"": [
            { ""p1"": ""0,7,10,12"" },
            { ""p2"": ""1,7,10,12"" },
            { ""p3"": ""2,8,10,12"" },
            { ""p4"": ""3,8,10,12"" },
            { ""p5"": ""4,9,11,12"" },
            { ""p6"": ""5,9,11,12"" },
            { ""p7"": ""6,11,12"" },
        ],
        ""temp8"": [
            ""0,8,12,14"",
            ""1,8,12,14"",
            ""2,9,12,14"",
            ""3,9,12,14"",
            ""4,10,13,14"",
            ""5,10,13,14"",
            ""6,11,13,14"",
            ""7,11,13,14"",
    ");
            WriteLiteral("    ]\r\n    }\r\n\r\n\r\n\r\n    let TeamsArray = []\r\n    if ($(\'#Tcontainer\').length) {\r\n        $(\"#Tcontainer\").ready(function () {\r\n            $.ajax({\r\n                url: \"");
#nullable restore
#line 134 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\Bracket\Index.cshtml"
                 Write(Url.Action("GetTournamentJson", "Bracket"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                type: \'POST\',\r\n                data: {\r\n                    \'id1\': ");
#nullable restore
#line 137 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\Bracket\Index.cshtml"
                      Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                },
                error: function (xhr) {
                    alert('Error: ' + xhr.statusText);
                },
                success: function (result) {
                    TeamsArray = result.teams
                    drawStuff(8)
                },
            });
        })
    }

    function drawStuff(players) {
        let content = """";
        for (let i = 0; i < bracketTemplate[`Temp${players}`].length; i++) {
            content += `
            <div class=""player""
            id=""M${i}""
            style=""
            left: ${bracketTemplate[`Temp${players}`][i].x}px;
            bottom: ${bracketTemplate[`Temp${players}`][i].y}px;
            "">
            <p class=""teamNameText""></p>
            <div class=""hline""
            style=""
            height: ${bracketTemplate[`Temp${players}`][i].h}px;
            "">

            <div class=""wline${bracketTemplate[`Temp${players}`][i].dir}""
            style=""
            width: ${bracketTemplat");
            WriteLiteral(@"e[`Temp${players}`][i].w}px;
            "">

            </div>
            </div>
            </div>
            `
        }
        let containerWidth = 100 * players;
        document.getElementById(""BracketContainer"").style.width = `${containerWidth - 100}px`
        document.getElementById(""BracketContainer"").innerHTML = content;


        let scrolltopos = ($(""#Tcontainer"").width() / 2)
        let scrollMinus = (scrolltopos - (window.innerWidth / 2))
        $(window).scrollLeft(scrollMinus)

        console.log(TeamsArray)
      GeneratePlacements()
    }

    function GeneratePlacements() {
        for (let u = 0; u < TeamsArray.length; u++) {
/*            let MatchPattern = patternTemplate[`temp${8}`][`p${u}`].split(',');*/
            let MatchPattern = patternTemplate[`temp${8}`][u].split(',');


            let Teams = GetContestants(MatchPattern[TeamsArray[u].matchWins]);
            if (Teams.player2) {
                document.getElementById(`M${Teams.player1.Inde");
            WriteLiteral(@"x}`).classList.add(""ActiveP"")
            }
            document.getElementById(`M${Teams.player1.Index}`).children[0].innerHTML = `${Teams.player1.teamName}`

            console.log(Teams)

            if (MatchPattern[TeamsArray[u].matchWins] == MatchPattern[MatchPattern.length - 1]) {
                document.getElementById(`M${Teams.player1.Index}`).classList.add(""Winner"")
            }
        }

        for (let u = 0; u < TeamsArray.length; u++) {
            let MatchPattern = patternTemplate[`temp${8}`][u].split(',');
            for (let i = 0; i <= TeamsArray[u].matchWins; i++) {

                if (i < TeamsArray[u].matchWins) {
                    document.getElementById(`M${MatchPattern[i]}`).classList.add(""Won"")
                }
            }
            if (TeamsArray[u].lostGame) {
                for (let i = 0; i <= TeamsArray[u].matchWins; i++) {
                    document.getElementById(`M${MatchPattern[i]}`).classList.add(""Out"")
                }
            }");
            WriteLiteral(@"
        }
    }

    function GetContestants(PlayerOneIndex) {

        let test = new Object()
        for (let u = 0; u < TeamsArray.length; u++) {
            let MatchPattern = patternTemplate[`temp${8}`][u].split(',');
            if (MatchPattern[TeamsArray[u].matchWins] == PlayerOneIndex) {
                test.player1 = { ""teamId"": TeamsArray[u].teamId, ""Index"": MatchPattern[TeamsArray[u].matchWins], ""teamName"": TeamsArray[u].teamName }

                for (let i = 0; i < TeamsArray.length; i++) {
                    let MatchPatternNew = patternTemplate[`temp${8}`][i].split(',');


                    if (TeamsArray[u].matchWins < MatchPattern.length && TeamsArray[i].matchWins < MatchPatternNew.length) {
                        if (MatchPattern[TeamsArray[u].matchWins + 1] == MatchPatternNew[TeamsArray[i].matchWins + 1]
                            && MatchPattern[0] != MatchPatternNew[0]) {
                            test.player2 = { ""teamId"": TeamsArray[i].teamId, ""Index"": Matc");
            WriteLiteral(@"hPatternNew[TeamsArray[i].matchWins], ""teamName"": TeamsArray[i].teamName }
                        }
                    }
                }
            }
        }
        return test;
    }

    document.getElementById(""Tcontainer"").addEventListener(""click"", function (e) {
        if (e.target.classList.contains(""ActiveP"")) {
            let Index = e.target.id.substring(1)
            SetPlacements(Index)
        }
    })

    function SetPlacements(value) {

        let Teams = GetContestants(value)

        document.getElementById(`M${Teams.player1.Index}`).classList.toggle(""Winteam"")
        Updates[Teams.player1.teamId] = { ""Matchwins"": 1 }

        document.getElementById(`M${Teams.player2.Index}`).classList.toggle(""Out"")
        Updates[Teams.player2.teamId] = { ""Out"": true };


        console.log(Updates)

/*        data: { 'jsonstring': JSON.stringify(Updates) },*/
            $.ajax({
                url: """);
#nullable restore
#line 270 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\Bracket\Index.cshtml"
                 Write(Url.Action("UpdateTeams", "Bracket"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                type: \'POST\',\r\n                //dataType: \"json\",\r\n                //contentType: \"application/json; charset=utf-8\",\r\n                data: {\r\n                    \'id1\': ");
#nullable restore
#line 275 "C:\Users\nikol\OneDrive\Documents\GitHub\interdisciplinary\TournamentWeb\Views\Bracket\Index.cshtml"
                      Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                    'jsonstring': JSON.stringify(Updates)
                },
                error: function (xhr) {
                    alert('Error: ' + xhr.statusText);
                },
                success: function (result) {
                    window.location.href = result;
                },
            });
    }






    $(window).resize(function () {
        let scrolltopos = ($(""#Tcontainer"").width() / 2)
        let scrollMinus = (scrolltopos - (window.innerWidth / 2))
        $(window).scrollLeft(scrollMinus)
    });

        // drag controls
    const ele = document.getElementById(""Tcontainer"")

    // drag controls
    let pos = { top: 0, left: 0, x: 0, y: 0 };

    const mouseDownHandler = function (e) {
        ele.style.cursor = 'grabbing';
        ele.style.userSelect = 'none';
        pos = {
            // The current scroll
            left: $(window).scrollLeft(),
            top: $(window).scrollTop(),
            // Get the current mouse pos");
            WriteLiteral(@"ition

            x: e.clientX,
            y: e.clientY,
        };

        document.addEventListener('mousemove', mouseMoveHandler);
        document.addEventListener('mouseup', mouseUpHandler);
    };


    const mouseMoveHandler = function (e) {
        ele.style.cursor = 'grabbing';
        // How far the mouse has been moved
        const dx = e.clientX - pos.x;
        const dy = e.clientY - pos.y;

        // Scroll the element
        $(window).scrollTop(pos.top - dy);
        $(window).scrollLeft(pos.left - dx);
    };

    const mouseUpHandler = function () {
        ele.style.cursor = 'grab';
        ele.style.removeProperty('user-select');
        document.removeEventListener('mousemove', mouseMoveHandler);
    };

</script>

<style>

    body::-webkit-scrollbar {
        display: none;
    }

    body {
        -ms-overflow-style: none;
        scrollbar-width: none;
    }

    body, html {
        min-width: 1000px;
        max-height: 100vh;
      ");
            WriteLiteral(@"  margin: 0;
        padding: 0;
        overflow-y: hidden;
    }

    #Tcontainer {
        cursor: grab;
        height: 100%;
        width: 100vw;
        min-width: 1000px;
        background: rgb(164, 236, 218);
        transform: translate(-50%, -50%);
        position: relative;
        left: 50%;
        top: 50%
    }

    #BracketContainer {
        transform: translate(-50%, -50%);
        position: absolute;
        left: 50%;
        bottom: 0%;
    }

    .player {
        pointer-events: none;
        transform: translate(-50%, -50%);
        background: rgb(0, 0, 0);
        height: 40px;
        width: 82px;
        position: absolute;
        bottom: 20px;
    }

        .player:hover {
            cursor: pointer;
        }

        .player p {
            position: absolute;
            transform: translate(-50%, -0%);
            left: 50%;
            margin: 0;
            top: 100%;
            font-weight: bold;
            font-size: 20p");
            WriteLiteral(@"x;
        }

    .hline {
        width: 4px;
        transform: translate(-50%, -100%);
        position: relative;
        left: 50%;
        top: 50%;
        background: rgb(0, 0, 0);
    }

    .wlineR {
        height: 4px;
        position: relative;
        background: rgb(0, 0, 0);
    }

    .wlineL {
        height: 4px;
        transform: translateX(-100%);
        position: relative;
        background: rgb(0, 0, 0);
    }


    .ActiveP {
        pointer-events: initial;
        background: #3186f5 !important;
    }

        .ActiveP div {
            background: #3186f5 !important;
        }

    .Winteam div {
        background: #00fb3f !important;
    }

    .Winteam {
        background: #00fb3f !important;
    }

    .teamNameText {
        top: 10px !important;
        background: white;
        pointer-events: none;
    }

    .Out {
        opacity: 0.4;
        pointer-events: none;
        background: black !important;
    }

   ");
            WriteLiteral(@"     .Out div {
            opacity: 0.5;
            pointer-events: none;
            background: black !important;
        }

    .Won {
        background: #09ff00 !important;
        opacity: 0.7;
    }

        .Won div {
            background: #09ff00 !important;
            opacity: 0.7;
        }

    .Winner {
        background: yellow !important;
    }

        .Winner div {
            background: yellow !important;
        }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
