using Newtonsoft.Json;
using System;

public class Message
{
    public string text { get; set; }
    public string html { get; set; }
    public string markdown { get; set; }
}

public class DetailedMessage
{
    public string text { get; set; }
    public string html { get; set; }
    public string markdown { get; set; }
}

public class Avatar
{
    public string href { get; set; }
}

public class Links
{
    public Avatar avatar { get; set; }
}

public class SystemCreatedBy
{
    public string displayName { get; set; }
    public string url { get; set; }
    public Links _links { get; set; }
    public string id { get; set; }
    public string uniqueName { get; set; }
    public string imageUrl { get; set; }
    public string descriptor { get; set; }
}

public class Avatar2
{
    public string href { get; set; }
}

public class Links2
{
    public Avatar2 avatar { get; set; }
}

public class SystemChangedBy
{
    public string displayName { get; set; }
    public string url { get; set; }
    public Links2 _links { get; set; }
    public string id { get; set; }
    public string uniqueName { get; set; }
    public string imageUrl { get; set; }
    public string descriptor { get; set; }
}

public class Fields
{
    [JsonProperty (PropertyName= "System.AreaPath") ]
    public string AreaPath { get; set; }

    [JsonProperty (PropertyName= "System.TeamProject") ]
    public string TeamProject { get; set; }

    [JsonProperty (PropertyName= "System.IterationPath") ]
    public string IterationPath { get; set; }

    [JsonProperty (PropertyName= "System.WorkItemType") ]
    public string WorkItemType { get; set; }

    [JsonProperty (PropertyName= "System.State") ]
    public string State { get; set; }

    [JsonProperty (PropertyName= "System.Reason") ]
    public string Reason { get; set; }

    [JsonProperty (PropertyName= "System.CreatedDate") ]
    public DateTime CreatedDate { get; set; }

    [JsonProperty (PropertyName= "System.CreatedBy") ]
    public SystemCreatedBy CreatedBy { get; set; }

    [JsonProperty (PropertyName= "System.ChangedDate") ]
    public DateTime ChangedDate { get; set; }

    [JsonProperty (PropertyName= "System.ChangedBy") ]
    public SystemChangedBy ChangedBy { get; set; }

    [JsonProperty (PropertyName= "System.Title") ]
    public string Title { get; set; }
   

}

public class Self
{
    public string href { get; set; }
}

public class WorkItemUpdates
{
    public string href { get; set; }
}

public class WorkItemRevisions
{
    public string href { get; set; }
}

public class WorkItemType
{
    public string href { get; set; }
}

public class Fields2
{
    public string href { get; set; }
}

public class Links3
{
    public Self self { get; set; }
    public WorkItemUpdates workItemUpdates { get; set; }
    public WorkItemRevisions workItemRevisions { get; set; }
    public WorkItemType workItemType { get; set; }
    public Fields2 fields { get; set; }
}

public class Resource
{
    public int id { get; set; }
    public int rev { get; set; }
    public Fields fields { get; set; }
    public Links3 _links { get; set; }
    public string url { get; set; }
}

public class Collection
{
    public string id { get; set; }
}

public class Account
{
    public string id { get; set; }
}

public class Project
{
    public string id { get; set; }
}

public class ResourceContainers
{
    public Collection collection { get; set; }
    public Account account { get; set; }
    public Project project { get; set; }
}

public class Task
{
    public string subscriptionId { get; set; }
    public int notificationId { get; set; }
    public string id { get; set; }
    public string eventType { get; set; }
    public string publisherId { get; set; }
    public Message message { get; set; }
    public DetailedMessage detailedMessage { get; set; }
    public Resource resource { get; set; }
    public string resourceVersion { get; set; }
    public ResourceContainers resourceContainers { get; set; }
    public DateTime createdDate { get; set; }
}