document.addEventListener('DOMContentLoaded', () => {
    // Tạo một vùng chứa cho bông tuyết
    const container = document.createElement('div');
    container.classList.add('snowflakes');
    container.setAttribute('aria-hidden', 'true'); // Thêm thuộc tính aria-hidden cho container
    document.body.appendChild(container);

    // Thêm các phần tử bông tuyết vào vùng chứa
    for (let i = 0; i < 8; i++) {
        const snowflake = document.createElement('div');
        snowflake.classList.add('snowflake');

        // Thêm thuộc tính aria-hidden cho từng bông tuyết
        snowflake.setAttribute('aria-hidden', 'true');

        const inner = document.createElement('div');
        inner.classList.add('inner');
        inner.innerHTML = i % 2 === 0 ? '❅' : '🎅🏻'; // Thay đổi nội dung để thêm đa dạng

        snowflake.appendChild(inner);
        container.appendChild(snowflake);
    }
});
