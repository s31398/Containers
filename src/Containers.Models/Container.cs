﻿namespace Containers.Models;

public class Container
{
    public int ID { get; set; }
    public int ContainerType { get; set; }
    public bool isHazardous { get; set; }
    public string Name { get; set; }
    public int ContainerTypeId { get; set; }
}