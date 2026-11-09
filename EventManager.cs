using System;
using System.Collections.Generic;

namespace Assignment5
{

    internal class EventManager
    {
        // Private fields
        private string eventName;
        private double feePerParticipant;
        private double costPerParticipant;

        private ParticipantManager participantManager = new ParticipantManager();


        // Constructor
        public EventManager(string title, double feePerPerson, double costPerPerson)
        {
            this.eventName = title;
            this.feePerParticipant = feePerPerson;
            this.costPerParticipant = costPerPerson;
        }

        //Properties 
        public string EventName
        {
            get { return eventName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    eventName = value;
            }
        }
        public double CostPerParticipant
        {
            get { return costPerParticipant; }
            set
            {
                if (value >= 0.0)
                    costPerParticipant = value;
            }
        }

        public double FeePerParticipant
        {
            get { return feePerParticipant; }
            set
            {
                if (value >= 0.0)
                    feePerParticipant = value;
            }
        }

        // Access to participants
        public ParticipantManager Participants{get { return participantManager; }}

        // Financial calculations
        public int ParticipantCount{get { return participantManager.Count; }}

        public double TotalFees{get { return ParticipantCount * feePerParticipant; }}

        public double TotalCost{get { return ParticipantCount * costPerParticipant; }}

        public double Profit{ get { return TotalFees - TotalCost; }}

        // Add/Remove Participants
        public void AddParticipant(Participant p)
        {
            participantManager.AddParticipant(p);
        }  
    }
}
