.MODEL small
.STACK
.DATA
    var1 db 1
    var2 db 1
    result dw 0
.CODE
    mov ax, @data
    mov ds, ax
    
    mov al, [var1]
    mul var2
    mov [result], ax
END

