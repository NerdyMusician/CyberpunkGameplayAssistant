﻿using CyberpunkGameplayAssistant.Toolbox;
using System;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Cyberware : BaseModel
    {
        // Constructors
        public Cyberware()
        {

        }
        public Cyberware(string name)
        {
            Name = name;
        }
        public Cyberware(string name, string description)
        {
            Name = name;
            Description = description;
        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Description;
        [XmlSaveMode(XSME.Single)]
        public string Description
        {
            get => _Description;
            set => SetAndNotify(ref _Description, value);
        }

    }
}
