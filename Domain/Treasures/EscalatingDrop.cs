using Domain.Probabilities;

namespace Domain.Treasures;

public record struct EscalatingDrop(Drop Drop, EscalatingProbability Probability);