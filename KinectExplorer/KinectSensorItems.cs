//------------------------------------------------------------------------------
// <copyright file="KinectSensorItems.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.KinectExplorer
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Microsoft.Kinect;

    public class KinectSensorItems : ObservableCollection<KinectSensorItem>
    {
        private readonly Dictionary<KinectSensor, KinectSensorItem> sensorLookup = new Dictionary<KinectSensor, KinectSensorItem>();

        public Dictionary<KinectSensor, KinectSensorItem> SensorLookup
        {
            get
            {
                return this.sensorLookup;
            }
        }

        protected override void InsertItem(int index, KinectSensorItem item)
        {
            this.SensorLookup.Add(item.Sensor, item);
            base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            this.SensorLookup.Remove(this[index].Sensor);
            base.RemoveItem(index);
        }

        protected override void ClearItems()
        {
            this.SensorLookup.Clear();
            base.ClearItems();
        }
    }
}
