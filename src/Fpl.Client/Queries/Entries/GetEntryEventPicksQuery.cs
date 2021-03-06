using Fpl.Client.Models.EntryEventPicks;
using System.ComponentModel.DataAnnotations;

namespace Fpl.Client.Queries.Entries
{
    public class GetEntryEventPicksQuery : GetByEntryIdQuery<EntryEventPicks>
    {
        [Required]
        [Range(1, 38)]
        public int? EventId { get; init; }
        public override string Uri => $"{base.Uri}event/{EventId}/picks/";
    }
}