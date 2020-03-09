using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Updating_Child_Task_With_Story_Details_WebAPI.Models
{
    public class Fields
    {
        [JsonProperty(PropertyName = "System.AreaPath")]
        public string AreaPath { get; set; }

        [JsonProperty(PropertyName = "System.TeamProject")]
        public string TeamProject { get; set; }

        [JsonProperty(PropertyName = "System.Title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "System.Parent")]       
        public int Parent { get; set; }
        [JsonProperty(PropertyName = "System.Description ")]       
        public string Description { get; set; }
    }
    public class Resource
    {
        public int id { get; set; }
        public int rev { get; set; }
        public Fields fields { get; set; }

        public string url { get; set; }
    }
    public class Project
    {
        public string id { get; set; }
        public string baseUrl { get; set; }
    }

    public class ResourceContainers
    {
        public Project collection { get; set; }
        public Project account { get; set; }
        public Project project { get; set; }
    }
    public class Task
    {       
        public Resource resource { get; set; }
        public ResourceContainers resourceContainers { get; set; }
    }
    public class ModelProps
    {
        public string  baseUrl { get; set; }
        public string  projectId { get; set; }
        public string  PAT { get; set; }
        public int parentId { get; set; }

    }
}