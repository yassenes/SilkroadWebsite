window.positionTooltip = (tooltip, trigger) => {
    const triggerRect = trigger.getBoundingClientRect();
    const tooltipRect = tooltip.getBoundingClientRect();
    const viewportWidth = window.innerWidth;
    const viewportHeight = window.innerHeight;

    let left = triggerRect.right + 10;
    let top = triggerRect.top - 10;

    // Adjust if tooltip overflows right edge
    if (left + tooltipRect.width > viewportWidth) {
        left = triggerRect.left - tooltipRect.width - 10;
        tooltip.classList.add('tooltip-left');
    } else {
        tooltip.classList.remove('tooltip-left');
    }

    // Adjust if tooltip overflows bottom edge
    if (top + tooltipRect.height > viewportHeight) {
        top = viewportHeight - tooltipRect.height - 10;
    }

    tooltip.style.left = `${left}px`;
    tooltip.style.top = `${top}px`;
};