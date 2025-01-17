global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Services;

var apiService = new ApiService();

var loginSuccess = true;

await apiService.Login("ila.desai@winsor.edu", "NFK&&#laj631",
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    });
    
if(!loginSuccess)
    return;
    
var assesments = await apiService.SendAsync<AssesmentCalendar[]>(HttpMethod.Get,"api/assessment-calendar?", err =>
{
    Console.WriteLine(err);
    loginSuccess = false;
});

foreach (var assesment in assesments)
{
    Console.WriteLine(assesment);
}