function CheckForm()
{
    var lName = document.getElementById("lName").value;
    var vLName = document.getElementById("vLName").value;
    if (lName != vLName)
    {
        document.getElementById("mLName").value = "Passwords don't match";
        document.getElementById("mLName").style.display = "inline";
        return false;
    }
    return true;
}
