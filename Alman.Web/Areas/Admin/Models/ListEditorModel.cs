using Alman.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alman.Web.Areas.Admin.Models
{
    public class ListEditorModel
    {
        public List<DataPartition> DataPartitions { get; set; }
        public int SelectedPartitionId { get; set; }

        public List<string> EditorTypes { get; set; }
        public string SelectedEditorType { get; set; }

        public List<SelectionTypeEntity> Entities { get; set; }

        public ListEditorModel()
        {
            this.DataPartitions = new List<DataPartition>();
            this.Entities = new List<SelectionTypeEntity>();

            this.InitializeSelectionTypes();
        }

        private void InitializeSelectionTypes()
        {
            this.EditorTypes = SelectionEntities.GetSelectionEntities().ToList();

        }


    }
}