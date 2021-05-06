using System;

namespace assignment4
{
    class Queue
    {
        Trip[] arr;
        uint index;

        public Queue()
        {
            arr = new Trip[1];
            index = 0;
        }

        private Queue(Queue queue)
        {
            arr = new Trip[queue.arr.Length];
            queue.arr.CopyTo(arr, 0);
            index = queue.Length;
        }

        public Trip[] Arr => arr;
        
        public bool IsEmpty()
        {
           
            return index == 0;
        }

        public uint Length => index;

        public void Enqueue(Trip trip)
        {
            for (int i = 0; i < index; i++)
            {
                if (arr[i].Date == trip.Date && arr[i].TripType == trip.TripType)
                {
                    Console.WriteLine("trip exists");
                    return;
                }
            }
            if (index >= arr.Length)
            {
                Trip[] temp = new Trip[arr.Length + 1];
                arr.CopyTo(temp, 0);
                arr = temp;
            }
            arr[index++] = trip;
        }

        public Trip Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return null;
            }
            Trip trip = arr[0];
            for (int i = 0; i < index - 1; i++)
                arr[i] = arr[i + 1];
            index--;
            arr[index] = null;//ניקוי האיבר האחרון
            return trip;
        }

        public int SearchTripByNum(uint trip_number)//אין צורך במתודה זאת Mian 
        {
            Queue copy = new Queue(this);
            Trip trip;
            int index = 0;
            while ((trip = copy.Dequeue()) != null)
            {
                if (trip.TripNumber == trip_number)
                    return index;
                index++;
                if (copy.IsEmpty())
                    break;
            }
            return -1;
        }

        public bool DeleteByTripNumber(uint trip_number)
        {
            bool res = false;
            Queue result = new Queue();
            Queue copy = new Queue(this);

            Trip trip;
            while ((trip = copy.Dequeue()) != null)
            {
                if (trip.TripNumber != trip_number)
                    result.Enqueue(trip);
                else
                    res = true;
                if (copy.IsEmpty())
                    break;
            }
            arr = result.arr;
            index = result.Length;
            return res;
        }

        public Trip[] SearchTripByType(TripType tripType)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return null;
            }
            Trip[] res = new Trip[Length];
            int num = 0;

            Queue copy = new Queue(this);
            Trip trip;
            while ((trip = copy.Dequeue()) != null)
            {
                if (trip.TripType == tripType)
                    res[num++] = trip;
                if (copy.IsEmpty())
                    break;
            }
            if (num == 0)
                return null;
            Trip[] res1 = new Trip[num];
            for (int i = 0; i < num; i++) // can't use CopyTo becuase res.Length > num (res1.Length)
                res1[i] = res[i];
            return res1;
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Queue copy = new Queue(this);
            Trip trip;
            while ((trip = copy.Dequeue()) != null)
            {

                trip.PrintTrip();
                if (copy.IsEmpty())
                    break;
                
            }
        }
    
      
    }
}
