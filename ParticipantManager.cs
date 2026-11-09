using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ParticipantManager
    {
        // List to store participants
        private List<Participant> participants = new List<Participant>();

        public void AddParticipant(Participant participant)
        {
            if (participant != null)
                participants.Add(participant);
        }

        // Remove participant by index
        public bool RemoveParticipant(int index)
        {
            if (CheckIndex(index))
            {
                participants.RemoveAt(index);
                return true;
            }
            return false;
        }

        // Adds a participant to the list
        public void AddParticipantAt(int index, Participant participant)
        {
            if (CheckIndex(index) && participant != null)
            {
                participants.Insert(index, participant);
            }
        }

        // Get a participant (returns a copy)
        public Participant GetParticipant(int index)
        {
            if (CheckIndex(index))
            {
                Participant original = participants[index];
                return new Participant(original.FirstName, original.LastName, original.Address);
            }
            return null;
        }

        // Get all participants
        public List<Participant> GetAllParticipants()
        {
            List<Participant> copyList = new List<Participant>();
            foreach (Participant p in participants)
            {
                copyList.Add(new Participant(p.FirstName, p.LastName, p.Address));
            }
            return copyList;
        }

        // Check if index is valid
        private bool CheckIndex(int index)
        {
            return index >= 0 && index < participants.Count;
        }

        // Get the number of participants
        public int Count
        {
            get { return participants.Count; }
        }

        //delete a participant
        public void RemoveAt(int index)
        {
            if (CheckIndex(index))
                participants.RemoveAt(index);
        }

        //Updates the participant at the given index with a new participant object
        public void UpdateParticipantAt(int index, Participant participant)
        {
            if (CheckIndex(index) && participant != null)
            {
                participants[index] = participant;
            }
        }
    }
}
