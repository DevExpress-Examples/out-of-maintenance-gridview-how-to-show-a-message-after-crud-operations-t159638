<script type="text/javascript">
    function OnEndCallback(s, e) {
        if (s.cpMessage) {
            alert(s.cpMessage);
            lblDevExpress.SetText("DevExpress Label: Updated Via DevExpress Client-Side API: " + s.cpMessage);
            $("#lblStandard").text("Standard Label: Updated Via jQuery: " + s.cpMessage);
            delete s.cpMessage;
        }
    }
</script>

@Html.Action("GridViewPartial")

@Html.DevExpress().Label( _
    Sub(lbl)
            lbl.Name = "lblDevExpress"
            lbl.Properties.EnableClientSideAPI = True
    End Sub).GetHtml()

<br />

<label id="lblStandard"></label>