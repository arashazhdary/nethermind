//  Copyright (c) 2018 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.

using Nethermind.Core;

namespace Nethermind.Synchronization.Reporting
{
    public class NullSyncReport : ISyncReport
    {
        public void Dispose()
        {
        }
        
        public static NullSyncReport Instance = new NullSyncReport(); 

        public MeasuredProgress FullSyncBlocksDownloaded { get; } = new MeasuredProgress();
        public long FullSyncBlocksKnown { get; set; }
        public MeasuredProgress HeadersInQueue { get; } = new MeasuredProgress();
        public MeasuredProgress BodiesInQueue { get; } = new MeasuredProgress();
        public MeasuredProgress ReceiptsInQueue { get; } = new MeasuredProgress();
        public MeasuredProgress FastBlocksHeaders { get; } = new MeasuredProgress();
        public MeasuredProgress FastBlocksBodies { get; } = new MeasuredProgress();
        public MeasuredProgress FastBlocksReceipts { get; } = new MeasuredProgress();
    }
}