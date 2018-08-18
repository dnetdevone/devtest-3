@ModelType GetPlayerRanking
@Code
    ViewData("Title") = "Get Player Ranking"
End Code

<div class="Index">
    <h1>Player Ranking Lookup</h1>

</div>


@Using Html.BeginForm()

    @<div class="row">
        <div class="col-md-6">
            <div class="form-group">
                @Html.LabelFor(Function(m) m.Name, "Player Name")
                @Html.TextBoxFor(Function(m) m.Name, New With {.class = "form-control"})
            </div>
            <button class="btn btn-primary" type="submit" value="Submit">Submit</button>

            @If Model.Ranking > 0 Then
                @<div class="row">
                    <div class="col-md-4">
                        <h2>@Model.Name</h2>
                        <p>
                            <strong>Ranking:</strong>  @Model.Ranking
                        </p>

                    </div>

                </div>
            ElseIf Model.Name Is Nothing And Model.Ranking = 0 Then

                @<div class="row">
                    <div class="col-md-8">
                        <h2>Could not find player: @ViewBag.Name </h2>                     

                    </div>

                </div>
            End If

        </div>
    </div>

End Using 
