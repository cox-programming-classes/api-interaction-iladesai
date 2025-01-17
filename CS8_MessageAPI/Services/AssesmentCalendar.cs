namespace CS8_MessageAPI.Services;


    public record AssesmentCalendar(
        String id,
        String type,
        String summary,
        String description,
        String start,
        String end,
        bool allday,
        String[] affectedClasses,
        bool? passUsed,
        bool? passAvailable

    );

    public record AssesmentDetails(
        String assesmentId,
        String displayName,
        String block,
        String assesmentDateTime,
        String Teacher,
        String [] Students,
        bool latePass,
        int conflictCount,
        bool redFlag

    );
    
 /*   
{
    "assessmentId": "8g9QVsEGdNVZ",
    "displayName": "United States Literature",
    "block": "B",
    "assessmentDateTime": "2025-01-13T13:30:00",
    "teacher": {
        "id": "4b6AK3ly1XKD",
        "firstName": "Laura",
        "lastName": "Krier",
        "email": "lkrier@winsor.edu"
    },
    "students": [
    {
        "student": {
            "id": "9q8gdPYgY6Oy",
            "displayName": "Ila Desai",
            "email": "ila.desai@winsor.edu",
            "gradYear": 2027,
            "className": "Class VI",
            "advisorName": "Kate Allen"
        },
        "latePass": false,
        "conflictCount": 0,
        "redFlag": false
    },
    
    */